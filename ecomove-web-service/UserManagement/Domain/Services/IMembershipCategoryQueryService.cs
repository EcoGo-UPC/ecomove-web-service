using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Model.Queries;

namespace ecomove_web_service.UserManagement.Domain.Services;

/**
 * IMembershipCategoryQueryService interface
 * Represents a service for membership categories
 * A membership category is a type of membership
 */
public interface IMembershipCategoryQueryService
{
    Task<MembershipCategory?> Handle(GetMembershipCategoryByMembershipCategoryIdQuery query);
}