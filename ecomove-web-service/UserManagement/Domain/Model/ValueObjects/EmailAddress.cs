namespace ecomove_web_service.UserManagement.Domain.Model.ValueObjects;

public record EmailAddress(string Address)
{
    public EmailAddress(): this(string.Empty){}
}