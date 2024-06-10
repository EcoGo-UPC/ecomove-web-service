using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.UserId, user.FullName, user.EmailAddress, user.Username);
    }
}