using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.CustomerSupport.Application.Internal.CommandServices;

/**
 * This class is responsible for handling the business logic of the TicketCategory entity.
 */
public class TicketCategoryCommandService(ITicketCategoryRepository ticketCategoryRepository, IUnitOfWork unitOfWork)
    : ITicketCategoryCommandService
{
    /**
     * This method is responsible for handling the business logic of creating a TicketCategory entity.
     * <param name="command">The CreateTicketCategoryCommand</param>
     * <returns>The TicketCategory</returns>
     */
    public async Task<TicketCategory?> Handle(CreateTicketCategoryCommand command)
    {
        var ticketCategory = new TicketCategory(command.Name);
        await ticketCategoryRepository.AddAsync(ticketCategory);
        await unitOfWork.CompleteAsync();
        return ticketCategory;
    }
}