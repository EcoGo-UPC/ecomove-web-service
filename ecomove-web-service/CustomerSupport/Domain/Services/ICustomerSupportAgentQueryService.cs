using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;

namespace ecomove_web_service.CustomerSupport.Domain.Services;

public interface ICustomerSupportAgentQueryService
{
    Task<CustomerSupportAgent?> Handle(GetCustomerSupportAgentByCustomerSupportAgentIdQuery query);
}