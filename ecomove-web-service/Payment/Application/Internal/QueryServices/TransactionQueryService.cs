using ecomove_web_service.Payment.Domain.Model.Aggregates;
using ecomove_web_service.Payment.Domain.Model.Queries;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Payment.Domain.Services;

namespace ecomove_web_service.Payment.Application.Internal.QueryServices;

/**
 * Service for handling transaction queries.
 * <param name="transactionRepository">The transaction repository.</param>
 * <remarks>
 * This class implements the ITransactionQueryService interface.
 * </remarks>
 */
public class TransactionQueryService(ITransactionRepository transactionRepository): ITransactionQueryService
{
    public async Task<IEnumerable<Transaction>> Handle(GetAllTransactionsByUserIdQuery query)
    {
        return await transactionRepository.FindAllTransactionsByUserIdAsync(query.UserId);
    }
}