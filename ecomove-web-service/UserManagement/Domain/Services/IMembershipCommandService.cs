using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Domain.Model.Commands;

namespace ecomove_web_service.UserManagement.Domain.Services;

public interface IMembershipCommandService
{
    public Task<Membership> Handle(CreateMembershipCommand command);
}