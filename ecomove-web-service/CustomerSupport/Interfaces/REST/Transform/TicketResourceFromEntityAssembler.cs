using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class TicketResourceFromEntityAssembler
{
    public static TicketResource ToResourceFromEntity(Ticket entity)
    {
        return new TicketResource(entity.TicketId, entity.Title, entity.Description, entity.TicketCategoryId, entity.Status, entity.CustomerSupportAgentId, entity.UserId);
    }
}