using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.UserManagement.Interfaces.ACL;
/**
 * IUserManagementContextFacade interface
 * Represents a facade for user management context
 * A user management context is a context for user management
 
 */
public interface IUserManagementContextFacade
{
    Task<int> CreateUser(string firstName, string lastName, string email, string username, string password);
    Task<int> FetchUserIdByUsername(string username);
    Task<string> FetchUsernameByUserId(int userId);
    Task<User?> FetchUserByUserId(int userId);
}