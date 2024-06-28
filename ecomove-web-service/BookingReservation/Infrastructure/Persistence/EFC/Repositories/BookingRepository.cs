using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ecomove_web_service.BookingReservation.Infrastructure.Persistence.EFC.Repositories;

public class BookingRepository(AppDbContext context) : BaseRepository<Booking>(context), IBookingRepository 
{
    public Task<Booking?> FindBookingByIdAsync(int id)
    {
        return Context.Set<Booking>().Where(b => b.BookingId == id).FirstOrDefaultAsync();
    }
    
    public async Task<IEnumerable<Booking>> FindAllBookingsByUserIdAsync(int userId)
    {
        return await Context.Set<Booking>().Where(b => b.UserId == userId).ToListAsync();
    }
}