using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Model.Queries;

namespace ecomove_web_service.UserManagement.Domain.Services;

public interface IMembershipCategoryQueryService
{
    Task<MembershipCategory?> Handle(GetMembershipCategoryByMembershipCategoryIdQuery query);
}