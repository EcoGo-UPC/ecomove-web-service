using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;

namespace ecomove_web_service.CustomerSupport.Domain.Services;

public interface ITicketQueryService
{
    Task<Ticket?> Handle(GetTicketByTicketIdQuery query);
    Task<IEnumerable<Ticket>> Handle(GetAllTicketsByUserIdQuery query);
    Task<IEnumerable<Ticket>> Handle(GetAllTicketsByCustomerSupportAgentIdQuery query);
}