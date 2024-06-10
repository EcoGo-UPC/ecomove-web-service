using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;

namespace ecomove_web_service.CustomerSupport.Application.Internal.QueryServices;

public class TicketQueryService(ITicketRepository ticketRepository)
    : ITicketQueryService
{
    public async Task<Ticket?> Handle(GetTicketByTicketIdQuery query)
    {
        return await ticketRepository.FindByIdAsync(query.TicketId);
    }
    public async Task<IEnumerable<Ticket>> Handle(GetAllTicketsByUserIdQuery query)
    {
        return await ticketRepository.FindByUserIdAsync(query.UserId);
    }

    public async Task<IEnumerable<Ticket>> Handle(GetAllTicketsByCustomerSupportAgentIdQuery query)
    {
        return await ticketRepository.FindByCustomerSupportAgentIdAsync(query.CustomerSupportAgentId);
    }
}
