using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class CreateCustomerSupportAgentCommandFromResourceAssembler
{
    public static CreateCustomerSupportAgentCommand ToCommandFromResource(CreateCustomerSupportAgentResource resource)
    {
        return new CreateCustomerSupportAgentCommand(resource.FirstName, resource.LastName, resource.Email);
    }
}