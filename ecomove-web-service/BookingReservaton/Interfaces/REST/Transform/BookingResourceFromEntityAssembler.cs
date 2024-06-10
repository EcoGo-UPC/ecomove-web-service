using ecomove_web_service.BookingReservation.Domain.Model.Aggregates;
using ecomove_web_service.BookingReservation.Interfaces.REST.Resources;

namespace ecomove_web_service.BookingReservation.Interfaces.REST.Transform;

public static class BookingResourceFromEntityAssembler
{
    public static BookingResource ToResourceFromEntity(Booking entity)
    {
        return new BookingResource(entity.BookingId, entity.UserId, entity.VehicleId, entity.StartTime, entity.EndTime, entity.Status);
    }
}