namespace ecomove_web_service.Payment.Interfaces.REST.Resources;

public record CreateCardResource(int UserId, string CardNumber, string ExpirationDate);