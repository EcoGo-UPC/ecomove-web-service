using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class CreateMembershipCategoryCommandFromResourceAssembler
{
    public static CreateMembershipCategoryCommand ToCommandFromResource(CreateMembershipCategoryResource resource)
    {
        return new CreateMembershipCategoryCommand(resource.Name);
    }
}