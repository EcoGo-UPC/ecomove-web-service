namespace ecomove_web_service.UserManagement.Interfaces.ACL;

public interface IUserManagementContextFacade
{
    Task<int> CreateUser(string firstName, string lastName, string email, string username, string password);
    Task<int> FetchUserIdByUsername(string username);
    Task<string> FetchUsernameByUserId(int userId);
}