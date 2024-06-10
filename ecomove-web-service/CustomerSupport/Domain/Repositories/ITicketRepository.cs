using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Domain.Repositories;

public interface ITicketRepository : IBaseRepository<Ticket>
{
    Task<IEnumerable<Ticket>> FindByCustomerSupportAgentIdAsync(int customerId);
    Task<IEnumerable<Ticket>> FindByUserIdAsync(int agentId);
}