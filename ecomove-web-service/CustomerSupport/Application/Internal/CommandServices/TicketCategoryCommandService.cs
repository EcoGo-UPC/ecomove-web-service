using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Application.Internal.CommandServices;

public class TicketCategoryCommandService(ITicketCategoryRepository ticketCategoryRepository, IUnitOfWork unitOfWork)
    : ITicketCategoryCommandService
{
    public async Task<TicketCategory?> Handle(CreateTicketCategoryCommand command)
    {
        var ticketCategory = new TicketCategory(command.Name);
        await ticketCategoryRepository.AddAsync(ticketCategory);
        await unitOfWork.CompleteAsync();
        return ticketCategory;
    }
}