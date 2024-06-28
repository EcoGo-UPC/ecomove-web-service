using ecomove_web_service.UserManagement.Domain.Model.Commands;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.FirstName, resource.LastName, resource.Email, resource.Username,
            resource.Password);
    }
}