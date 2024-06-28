using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Queries;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.QueryServices;

/**
 * MembershipQueryService is a class that implements the IMembershipQueryService interface.
 * <param name="membershipRepository">The membership repository.</param>
 */
public class MembershipQueryService(IMembershipRepository membershipRepository): IMembershipQueryService
{
    public async Task<Membership?> Handle(GetMembershipByMembershipIdQuery query)
    {
        return await membershipRepository.FindByIdAsync(query.MembershipId);
    }
    
    public async Task<Membership?> Handle(GetMembershipByUserIdQuery query)
    {
        return await membershipRepository.FindByUserIdAsync(query.UserId);
    }
}