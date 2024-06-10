using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Domain.Model.Queries;

namespace ecomove_web_service.BookingReservation.Domain.Services;

public interface IBookingQueryService
{
    Task<IEnumerable<Booking>> Handle(GetAllBookingsQuery query);
    Task<IEnumerable<Booking>> Handle(GetAllBookingsByUserIdQuery query);
    Task<Booking?> Handle(GetBookingByBookingIdQuery query);
}