namespace ecomove_web_service.UserManagement.Domain.Model.Commands;

public record CreateUserCommand(string FirstName, string LastName, string Email);