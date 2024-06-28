using ecomove_web_service.Payment.Domain.Model.Aggregates;
using ecomove_web_service.Payment.Domain.Model.Commands;

namespace ecomove_web_service.Payment.Domain.Services;

public interface ITransactionCommandService
{
    Task<Transaction?> Handle(CreateTransactionCommand command);
}