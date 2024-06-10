using ecomove_web_service.UserManagement.Domain.Model.Aggregates;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class MembershipResourceFromEntityAssembler
{
    public static MembershipResource ToResourceFromEntity(Membership entity)
    {
        return new MembershipResource(entity.UserId, entity.UserId, entity.MembershipCategoryId);
    }
}