using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class CreateMembershipCommandFromResourceAssembler
{
    public static CreateMembershipCommand ToCommandFromResource(CreateMembershipResource resource)
    {
        return new CreateMembershipCommand(resource.UserId, resource.MembershipCategoryId);
    }
}