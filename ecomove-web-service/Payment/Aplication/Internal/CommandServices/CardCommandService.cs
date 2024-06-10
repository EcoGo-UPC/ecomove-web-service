using ecomove_web_service.Payment.Domain.Model.Commands;
using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Payment.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Repositories;

namespace ecomove_web_service.Payment.Application.Internal.CommandServices;

public class CardCommandService(ICardRepository cardRepository, IUserRepository userRepository, IUnitOfWork unitOfWork) : ICardCommandService
{
    public async Task<Card?> Handle(CreateCardCommand command)
    {
        var card = new Card(command.UserId, command.CardNumber, command.ExpirationDate);
        await cardRepository.AddAsync(card);
        await unitOfWork.CompleteAsync();
        var user = await userRepository.FindByIdAsync(command.UserId);
        card.User = user;
        return card;
    }
}