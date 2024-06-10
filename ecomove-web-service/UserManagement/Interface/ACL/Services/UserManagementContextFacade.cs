using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Domain.Model.Queries;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Interfaces.ACL.Services;

public class UserManagementContextFacade(IUserCommandService userCommandService, IUserQueryService userQueryService) : IUserManagementContextFacade
{
    public async Task<int> CreateUser(string firstName, string lastName, string email, string username, string password)
    {
        var signUpCommand = new SignUpCommand(firstName, lastName, email, username, password);
        await userCommandService.Handle(signUpCommand);
        var getUserByUsernameQuery = new GetUserByUsernameQuery(username);
        var result = await userQueryService.Handle(getUserByUsernameQuery);
        return result?.UserId ?? 0;
    }
    public async Task<int> FetchUserIdByUsername(string username)
    {
        var getUserByUsernameQuery = new GetUserByUsernameQuery(username);
        var result = await userQueryService.Handle(getUserByUsernameQuery);
        return result?.UserId ?? 0;
    }
    public async Task<string> FetchUsernameByUserId(int userId)
    {
        var getUserByIdQuery = new GetUserByUserIdQuery(userId);
        var result = await userQueryService.Handle(getUserByIdQuery);
        return result?.Username ?? string.Empty;
    }
    
}