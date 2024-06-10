using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Commands;

namespace ecomove_web_service.CustomerSupport.Domain.Services;

public interface ITicketCommandService
{
    public Task<Ticket> Handle(CreateTicketCommand command);
}