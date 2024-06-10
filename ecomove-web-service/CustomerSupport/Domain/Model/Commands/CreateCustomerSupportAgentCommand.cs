namespace ecomove_web_service.CustomerSupport.Domain.Model.Commands;

public record CreateCustomerSupportAgentCommand(string FirstName, string LastName, string Email);