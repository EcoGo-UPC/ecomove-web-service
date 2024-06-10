using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.CustomerSupport.Infrastructure.Persistence.EFC.Repositories;

public class TicketRepository(AppDbContext context) : BaseRepository<Ticket>(context), ITicketRepository
{
    public async Task<IEnumerable<Ticket>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Ticket>().Where(ticket => ticket.UserId == userId).ToListAsync();
    }
    
    public async Task<IEnumerable<Ticket>> FindByCustomerSupportAgentIdAsync(int agentId)
    {
        return await Context.Set<Ticket>().Where(ticket => ticket.CustomerSupportAgentId == agentId).ToListAsync();
    }
}