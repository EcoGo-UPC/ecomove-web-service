using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Domain.Model.Commands;
using ecomove_web_service.BookingReservation.Domain.Repositories;
using ecomove_web_service.BookingReservation.Domain.Services;
using ecomove_web_service.Shared.Domain.Repositories;

namespace ecomove_web_service.BookingReservation.Application.Internal.CommandServices;

public class BookingCommandService(IBookingRepository bookingRepository, IUnitOfWork unitOfWork) : IBookingCommandService
{
    public async Task<Booking?> Handle(CreateBookingCommand command)
    {
        var booking = new Booking(command);
        try
        {
            await bookingRepository.AddAsync(booking);
            await unitOfWork.CompleteAsync();
            return booking;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the booking: {e.Message}");
            return null;
        }
    }
}