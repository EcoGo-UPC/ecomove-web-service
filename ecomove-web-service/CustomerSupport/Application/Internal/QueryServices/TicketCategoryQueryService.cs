using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;

namespace ecomove_web_service.CustomerSupport.Application.Internal.QueryServices;

public class TicketCategoryQueryService(ITicketCategoryRepository ticketCategoryRepository)
    : ITicketCategoryQueryService
{
    public async Task<TicketCategory?> Handle(GetTicketCategoryByTicketCategoryIdQuery query)
    {
        return await ticketCategoryRepository.FindByIdAsync(query.TicketCategoryId);
    }
}