using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.UserManagement.Domain.Model.Entities;
using ecomove_web_service.UserManagement.Domain.Repositories;

namespace ecomove_web_service.UserManagement.Infrastructure.Persistence.EFC.Repositories;

public class MembershipCategoryRepository(AppDbContext context) : BaseRepository<MembershipCategory>(context), IMembershipCategoryRepository
{
    
}