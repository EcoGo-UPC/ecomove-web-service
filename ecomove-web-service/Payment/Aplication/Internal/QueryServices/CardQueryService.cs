using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Payment.Domain.Model.Queries;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Payment.Domain.Services;

namespace ecomove_web_service.Payment.Application.Internal.QueryServices;

public class CardQueryService(ICardRepository cardRepository) : ICardQueryService
{
    public async Task<Card?> Handle(GetCardByUserIdQuery query)
    {
        return await cardRepository.FindByUserIdAsync(query.UserId);
    }
    public async Task<Card?> Handle(GetCardByCardIdQuery query)
    {
        return await cardRepository.FindByIdAsync(query.CardId);
    }
}
