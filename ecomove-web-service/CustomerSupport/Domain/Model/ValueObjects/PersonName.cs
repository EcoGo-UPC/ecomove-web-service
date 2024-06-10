namespace ecomove_web_service.CustomerSupport.Domain.Model.ValueObjects;

public record PersonName(string FirstName, string LastName)
{
    public PersonName() : this(string.Empty, string.Empty)
    {
    }

    public PersonName(string firstName) : this(firstName, string.Empty)
    {
    }

    public string FullName => $"{FirstName} {LastName}";
}