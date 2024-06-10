using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Queries;

namespace ecomove_web_service.UserManagement.Domain.Services;

public interface IMembershipQueryService
{
    Task<Membership?> Handle(GetMembershipByMembershipIdQuery query);
    Task<Membership?> Handle(GetMembershipByUserIdQuery query);
}