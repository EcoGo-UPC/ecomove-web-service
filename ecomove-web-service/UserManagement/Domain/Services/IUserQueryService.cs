using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Queries;

namespace ecomove_web_service.UserManagement.Domain.Services;

public interface IUserQueryService
{
    /**
     * <summary>
     *   Handle get user by user id query
     * </summary>
     * <param name="query">The query object containing the user id to search</param>
     * <returns>The user</returns>
     */
    Task<User?> Handle(GetUserByUserIdQuery query);
    
    /**
     * <summary>
     *   Handle get user by username query
     * </summary>
     * <param name="query">The query object containing the username to search</param>
     * <returns>The user</returns>
     */
    Task<User?> Handle(GetUserByUsernameQuery query);
}