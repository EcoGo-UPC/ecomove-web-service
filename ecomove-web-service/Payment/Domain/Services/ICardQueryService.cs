using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Payment.Domain.Model.Queries;

namespace ecomove_web_service.Payment.Domain.Services;

public interface ICardQueryService
{
    public Task<Card?> Handle(GetCardByCardIdQuery query);
    public Task<Card?> Handle(GetCardByUserIdQuery query);
}