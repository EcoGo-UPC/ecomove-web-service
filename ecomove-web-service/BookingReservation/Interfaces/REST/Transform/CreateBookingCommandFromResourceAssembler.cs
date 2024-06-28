using ecomove_web_service.BookingReservation.Domain.Model.Commands;
using ecomove_web_service.BookingReservation.Interfaces.REST.Resources;

namespace ecomove_web_service.BookingReservation.Interfaces.REST.Transform;

public static class CreateBookingCommandFromResourceAssembler
{
    public static CreateBookingCommand ToCommandFromResource(CreateBookingResource resource)
    {
        return new CreateBookingCommand(resource.UserId, resource.VehicleId, resource.StartTime, resource.EndTime, resource.Status);
    }
}