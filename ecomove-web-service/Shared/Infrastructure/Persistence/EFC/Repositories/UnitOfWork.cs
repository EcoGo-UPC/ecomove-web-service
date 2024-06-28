using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context) => _context = context;
    
    public async Task CompleteAsync() => await _context.SaveChangesAsync();
}