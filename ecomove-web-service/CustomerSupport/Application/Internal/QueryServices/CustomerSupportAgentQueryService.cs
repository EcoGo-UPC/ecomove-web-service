using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;

namespace ecomove_web_service.CustomerSupport.Application.Internal.QueryServices;

public class CustomerSupportAgentQueryService(ICustomerSupportAgentRepository customerSupportAgentRepository)
    : ICustomerSupportAgentQueryService
{
    public async Task<CustomerSupportAgent?> Handle(GetCustomerSupportAgentByCustomerSupportAgentIdQuery query)
    {
        return await customerSupportAgentRepository.FindByIdAsync(query.CustomerSupportAgentId);
    }
}