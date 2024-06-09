using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class TicketCategoryResourceFromEntityAssembler
{
    public static TicketCategoryResource ToResourceFromEntity(TicketCategory entity)
    {
        return new TicketCategoryResource(entity.TicketCategoryId, entity.Name);
    }
}