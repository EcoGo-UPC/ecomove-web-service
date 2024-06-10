using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class CreateTicketCategoryCommandFromResourceAssembler
{
    public static CreateTicketCategoryCommand ToCommandFromResource(CreateTicketCategoryResource resource)
    {
        return new CreateTicketCategoryCommand(resource.Name);
    }
}