namespace ecomove_web_service.UserManagement.Domain.Model.Commands;

public record CreateMembershipCommand(int UserId, int MembershipCategoryId);