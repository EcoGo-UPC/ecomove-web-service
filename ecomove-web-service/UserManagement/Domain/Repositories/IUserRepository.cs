using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.UserManagement.Domain.Repositories;

public interface IUserRepository: IBaseRepository<User>
{
    /**
     * <summary>
     * Find a user by username
     * </summary>
     * <param name="username">The username of the user</param>
     * <returns>The user</returns>
     */
    Task<User?> FindByUsernameAsync(string username);
    
    /**
     * <summary>
     * Check if a user exists by username
     * </summary>
     * <param name="username">The username of the user</param>
     * <returns>True if the user exists, false otherwise</returns>
     */
    bool ExistsByUsername(string username);
}