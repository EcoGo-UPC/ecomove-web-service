using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Model.Queries;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;

namespace ecomove_web_service.UserManagement.Application.Internal.QueryServices;

/**
 * MembershipCategoryQueryService is a class that implements the IMembershipCategoryQueryService interface.
 * <param name="membershipCategoryRepository">The membership category repository.</param>
 * <remarks>
 * This class is responsible for handling queries related to membership categories.
 * </remarks>
 */
public class MembershipCategoryQueryService(IMembershipCategoryRepository membershipCategoryRepository)
    : IMembershipCategoryQueryService
{
    public async Task<MembershipCategory?> Handle(GetMembershipCategoryByMembershipCategoryIdQuery query)
    {
        return await membershipCategoryRepository.FindByIdAsync(query.MembershipCategoryId);
    }

}