using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class CreateTicketCommandFromResourceAssembler
{
    public static CreateTicketCommand ToCommandFromResource(CreateTicketResource resource)
    {
        return new CreateTicketCommand(resource.Title, resource.Description, resource.TicketCategoryId, resource.Status, resource.CustomerSupportAgentId, resource.UserId);
    }
}