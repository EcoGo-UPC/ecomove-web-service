namespace ecomove_web_service.CustomerSupport.Domain.Model.Commands;

public record CreateTicketCommand(
    string Title,
    string Description,
    int TicketCategoryId,
    string Status,
    int CustomerSupportAgentId,
    int UserId);