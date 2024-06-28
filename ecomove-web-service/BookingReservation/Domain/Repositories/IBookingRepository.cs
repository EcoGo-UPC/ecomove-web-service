using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.BookingReservation.Domain.Repositories;

public interface IBookingRepository : IBaseRepository<Booking>
{
    Task<Booking?> FindBookingByIdAsync(int booking);
    Task<IEnumerable<Booking>> FindAllBookingsByUserIdAsync(int userId);
}