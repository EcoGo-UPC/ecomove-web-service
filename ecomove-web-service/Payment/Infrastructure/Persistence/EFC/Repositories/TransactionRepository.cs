using ecomove_web_service.Payment.Domain.Model.Aggregates;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.Payment.Infrastructure.Persistence.EFC.Repositories;


/**
 * Transaction Repository
 * <summary>
 *  This class is used to interact with the database and perform CRUD operations on the Transaction entity.
 * </summary>
 * <remarks>
 *  This class extends the BaseRepository class and implements the ITransactionRepository interface.
 * </remarks>
 */
public class TransactionRepository(AppDbContext context): BaseRepository<Transaction>(context), ITransactionRepository
{
    public async Task<IEnumerable<Transaction>> FindAllTransactionsByUserIdAsync(int UserId)
    {
        return await Context.Set<Transaction>().Where(t => t.UserId == UserId).ToListAsync();
    }
}