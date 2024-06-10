using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;

namespace ecomove_web_service.UserManagement.Domain.Repositories;

public interface IMembershipRepository : IBaseRepository<Membership>
{
    Task<Membership?> FindByUserIdAsync(int userId);
}