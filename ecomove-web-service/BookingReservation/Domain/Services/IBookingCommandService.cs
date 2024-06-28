using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Domain.Model.Commands;

namespace ecomove_web_service.BookingReservation.Domain.Services;

public interface IBookingCommandService
{
    Task<Booking?> Handle(CreateBookingCommand command);
    
}