namespace ecomove_web_service.CustomerSupport.Domain.Model.ValueObjects;

public record EmailAddress(string Address)
{
    public EmailAddress(): this(string.Empty){}
}