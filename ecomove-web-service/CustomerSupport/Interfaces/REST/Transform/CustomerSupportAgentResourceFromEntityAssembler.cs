using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Interfaces.REST.Resources;

namespace ecomove_web_service.CustomerSupport.Interfaces.REST.Transform;

public static class CustomerSupportAgentResourceFromEntityAssembler
{
    public static CustomerSupportAgentResource ToResourceFromEntity(CustomerSupportAgent entity)
    {
        return new CustomerSupportAgentResource(entity.CustomerSupportAgentId, entity.FullName, entity.EmailAddress);
    }
}