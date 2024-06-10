using ecomove_web_service.Payment.Domain.Model.Commands;
using ecomove_web_service.Payment.Domain.Model.Entities;

namespace ecomove_web_service.Payment.Domain.Services;

public interface ICardCommandService
{
    public Task<Card?> Handle(CreateCardCommand command);
}