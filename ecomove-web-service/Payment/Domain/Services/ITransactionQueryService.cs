using ecomove_web_service.Payment.Domain.Model.Aggregates;
using ecomove_web_service.Payment.Domain.Model.Queries;

namespace ecomove_web_service.Payment.Domain.Services;

public interface ITransactionQueryService
{
    Task<IEnumerable<Transaction>> Handle(GetAllTransactionsByUserIdQuery query);
}