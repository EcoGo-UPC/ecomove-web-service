using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Payment.Interfaces.REST.Resources;

namespace ecomove_web_service.Payment.Interfaces.REST.Transform;

public static class CardResourceFromEntityAssembler
{
    public static CardResource ToResourceFromEntity(Card card)
    {
        return new CardResource(card.CardId, card.UserId, card.CardNumber, card.ExpirationDate);
    }
}