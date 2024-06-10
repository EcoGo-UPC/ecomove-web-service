using ecomove_web_service.Payment.Domain.Model.Entities;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.Payment.Infrastructure.Persistence.EFC.Repositories;

public class CardRepository(AppDbContext context) : BaseRepository<Card>(context), ICardRepository
{
    public Task<Card?> FindByUserIdAsync(int userId)
    {
        return Context.Set<Card>().FirstOrDefaultAsync(c => c.UserId == userId);
    }
}