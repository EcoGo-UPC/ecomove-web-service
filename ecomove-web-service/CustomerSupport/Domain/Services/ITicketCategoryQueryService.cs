using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Domain.Model.Queries;

namespace ecomove_web_service.CustomerSupport.Domain.Services;

public interface ITicketCategoryQueryService
{
    Task<TicketCategory?> Handle(GetTicketCategoryByTicketCategoryIdQuery query);
}