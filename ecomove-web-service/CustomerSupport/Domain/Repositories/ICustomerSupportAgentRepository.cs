using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Domain.Repositories;

public interface ICustomerSupportAgentRepository : IBaseRepository<CustomerSupportAgent>
{
    Task<CustomerSupportAgent?> FindCustomerSupportAgentByIdAsync(int customerSupportAgentId);
    
}