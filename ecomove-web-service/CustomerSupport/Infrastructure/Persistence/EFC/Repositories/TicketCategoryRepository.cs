using ecomove_web_service.CustomerSupport.Domain.Model.Entities;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace ecomove_web_service.CustomerSupport.Infrastructure.Persistence.EFC.Repositories;

public class TicketCategoryRepository(AppDbContext context)
    : BaseRepository<TicketCategory>(context), ITicketCategoryRepository;
