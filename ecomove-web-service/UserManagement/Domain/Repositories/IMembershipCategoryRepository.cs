using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Entities;

namespace ecomove_web_service.UserManagement.Domain.Repositories;

/**
 * IMembershipCategoryRepository interface
 * Represents a repository for membership categories
 * A membership category is a type of membership
 */
public interface IMembershipCategoryRepository: IBaseRepository<MembershipCategory>
{ }