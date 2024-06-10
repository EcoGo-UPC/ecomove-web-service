using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Domain.Model.Queries;
using ecomove_web_service.BookingReservation.Domain.Repositories;
using ecomove_web_service.BookingReservation.Domain.Services;

namespace ecomove_web_service.BookingReservation.Application.Internal.QueryServices;

public class BookingQueryService(IBookingRepository bookingRepository) : IBookingQueryService
{
    public async Task<IEnumerable<Booking>> Handle(GetAllBookingsQuery query)
    {
        return await bookingRepository.ListAsync();
    }
    
    public async Task<IEnumerable<Booking>> Handle(GetAllBookingsByUserIdQuery query)
    {
        return await bookingRepository.FindAllBookingsByUserIdAsync(query.UserId);
    }
    
    public async Task<Booking?> Handle(GetBookingByBookingIdQuery query)
    {
        return await bookingRepository.FindBookingByIdAsync(query.BookingId);
    }
}