using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Application.Internal.OutboundServices;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.CommandServices;

public class UserCommandService(
    IUserRepository userRepository,
    ITokenService tokenService,
    IHashingService hashingService,
    IUnitOfWork unitOfWork)
    : IUserCommandService
{
    public async Task<(User user, string token)> Handle(SignInCommand command)
    {
        var user = await userRepository.FindByUsernameAsync(command.Username);

        if (user == null || !hashingService.VerifyPassword(command.Password, user.PasswordHash))
            throw new Exception("Invalid username or password");

        var token = tokenService.GenerateToken(user);

        return (user, token);
    }

    public async Task Handle(SignUpCommand command)
    {
        if (userRepository.ExistsByUsername(command.Username))
            throw new Exception($"Username {command.Username} is already taken");
        var hashedPassword = hashingService.HashPassword(command.Password);
        var user = new User(command.FirstName, command.LastName, command.Email, command.Username, hashedPassword);
        try
        {
            await userRepository.AddAsync(user);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            throw new Exception("$An error occurred while creating the user: {e.Message}");
        }
    }
}