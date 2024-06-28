using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Commands;

namespace ecomove_web_service.UserManagement.Domain.Services;

/**
 * IMembershipCommandService interface
 * Represents a service for memberships
 */
public interface IMembershipCommandService
{
    public Task<Membership> Handle(CreateMembershipCommand command);
}