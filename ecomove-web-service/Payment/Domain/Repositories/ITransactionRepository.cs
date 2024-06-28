using ecomove_web_service.Payment.Domain.Model.Aggregates;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.Payment.Domain.Repositories;

/**
 * Interface for the Transaction Repository
 * <summary>
 *   This interface is used to define the methods that the Transaction Repository must implement.
 * </summary>
 */
public interface ITransactionRepository : IBaseRepository<Transaction>
{
    Task<IEnumerable<Transaction>> FindAllTransactionsByUserIdAsync(int UserId);
}