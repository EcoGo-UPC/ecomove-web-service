namespace ecomove_web_service.UserManagement.Domain.Model.Commands;

/**
 * Command to create a membership category.
 * <param name="Name">The name of the membership category.</param>
 */
public record CreateMembershipCategoryCommand(string Name);