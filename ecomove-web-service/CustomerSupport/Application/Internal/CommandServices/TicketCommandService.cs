using ecomove_web_service.CustomerSupport.Domain.Model.Aggregates;
using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Application.Internal.CommandServices;

public class TicketCommandService(ITicketRepository ticketRepository, ITicketCategoryRepository ticketCategoryRepository, ICustomerSupportAgentRepository customerSupportAgentRepository, IUserRepository userRepository,  IUnitOfWork unitOfWork)
    : ITicketCommandService
{
    public async Task<Ticket?> Handle(CreateTicketCommand command)
    {
        var ticket = new Ticket(command.Title, command.Description, command.TicketCategoryId, command.Status,
            command.CustomerSupportAgentId, command.UserId);
        await ticketRepository.AddAsync(ticket);
        await unitOfWork.CompleteAsync();
        var ticketCategory = await ticketCategoryRepository.FindByIdAsync(command.TicketCategoryId);
        ticket.TicketCategory = ticketCategory;
        var customerSupportAgent = await customerSupportAgentRepository.FindByIdAsync(command.CustomerSupportAgentId);
        ticket.CustomerSupportAgent = customerSupportAgent;
        var user = await userRepository.FindByIdAsync(command.UserId);
        ticket.User = user;
        return ticket;
    }
}