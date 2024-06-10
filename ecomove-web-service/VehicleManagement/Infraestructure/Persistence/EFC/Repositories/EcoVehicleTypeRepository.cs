using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Model.Entities;
using ecomove_web_service.VehicleManagement.Domain.Repositories;

namespace ecomove_web_service.VehicleManagement.Infrastructure.Persistence.EFC.Repositories;

public class EcoVehicleTypeRepository(AppDbContext context): BaseRepository<EcoVehicleType>(context), IEcoVehicleTypeRepository {}