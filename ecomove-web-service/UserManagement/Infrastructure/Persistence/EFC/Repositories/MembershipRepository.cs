using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.UserManagement.Infrastructure.Persistence.EFC.Repositories;

public class MembershipRepository(AppDbContext context): BaseRepository<Membership>(context), IMembershipRepository
{
    public async Task<Membership?> FindMembershipByIdAsync(int membershipId)
    {
        return await Context.Set<Membership>().FirstOrDefaultAsync(membership => membership.MembershipId == membershipId);
    }
    
    public async Task<Membership?> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Membership>().OrderByDescending(membership => membership.CreatedDate).FirstOrDefaultAsync(membership => membership.UserId == userId);
    }
}