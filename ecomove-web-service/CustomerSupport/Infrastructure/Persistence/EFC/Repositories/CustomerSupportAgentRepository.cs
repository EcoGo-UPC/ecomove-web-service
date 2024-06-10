using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.CustomerSupport.Infrastructure.Persistence.EFC.Repositories;

public class CustomerSupportAgentRepository(AppDbContext context)
    : BaseRepository<CustomerSupportAgent>(context), ICustomerSupportAgentRepository
{
    public Task<CustomerSupportAgent?> FindCustomerSupportAgentByIdAsync(int customerSupportAgentId)
    {
        return Context.Set<CustomerSupportAgent>().FirstOrDefaultAsync(agent => agent.CustomerSupportAgentId == customerSupportAgentId);
    }
}