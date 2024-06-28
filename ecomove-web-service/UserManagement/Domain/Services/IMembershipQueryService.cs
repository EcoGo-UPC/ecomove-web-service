using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Queries;

namespace ecomove_web_service.UserManagement.Domain.Services;

/**
 * IMembershipQueryService interface
 * Represents a service for memberships
 
 */
public interface IMembershipQueryService
{
    Task<Membership?> Handle(GetMembershipByMembershipIdQuery query);
    Task<Membership?> Handle(GetMembershipByUserIdQuery query);
}