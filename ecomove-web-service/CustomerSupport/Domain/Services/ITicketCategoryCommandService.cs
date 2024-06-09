using ecomove_web_service.CustomerSupport.Domain.Model.Commands;
using ecomove_web_service.CustomerSupport.Domain.Model.Entities;

namespace ecomove_web_service.CustomerSupport.Domain.Services;

public interface ITicketCategoryCommandService
{
    public Task<TicketCategory?> Handle(CreateTicketCategoryCommand command);
}