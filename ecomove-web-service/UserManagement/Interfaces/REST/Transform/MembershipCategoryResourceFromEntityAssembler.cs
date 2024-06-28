using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Interfaces.REST.Resources;

namespace ecomove_web_service.UserManagement.Interfaces.REST.Transform;

public static class MembershipCategoryResourceFromEntityAssembler
{
    public static MembershipCategoryResource ToResourceFromEntity(MembershipCategory entity)
    {
        return new MembershipCategoryResource(entity.MembershipCategoryId, entity.Name);
    }
}