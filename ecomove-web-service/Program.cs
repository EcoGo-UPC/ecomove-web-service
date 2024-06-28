using ecomove_web_service.BookingReservation.Application.Internal.CommandServices;
using ecomove_web_service.BookingReservation.Application.Internal.OutboundServices.ACL;
using ecomove_web_service.BookingReservation.Application.Internal.QueryServices;
using ecomove_web_service.BookingReservation.Domain.Repositories;
using ecomove_web_service.BookingReservation.Domain.Services;
using ecomove_web_service.BookingReservation.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.CustomerSupport.Application.Internal.CommandServices;
using ecomove_web_service.CustomerSupport.Application.Internal.QueryServices;
using ecomove_web_service.CustomerSupport.Domain.Repositories;
using ecomove_web_service.CustomerSupport.Domain.Services;
using ecomove_web_service.CustomerSupport.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.Payment.Application.Internal.CommandServices;
using ecomove_web_service.Payment.Application.Internal.QueryServices;
using ecomove_web_service.Payment.Domain.Repositories;
using ecomove_web_service.Payment.Domain.Services;
using ecomove_web_service.Payment.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.Shared.Application.Internal.OutboundServices;
using ecomove_web_service.Shared.Domain.Repositories;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Configuration;
using ecomove_web_service.Shared.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.Shared.Interfaces.ASP.Configuration;
using ecomove_web_service.UserManagement.Application.Internal.CommandServices;
using ecomove_web_service.UserManagement.Application.Internal.OutboundServices;
using ecomove_web_service.UserManagement.Application.Internal.QueryServices;
using ecomove_web_service.UserManagement.Domain.Repositories;
using ecomove_web_service.UserManagement.Domain.Services;
using ecomove_web_service.UserManagement.Infrastructure.Hashing.BCrypt.Services;
using ecomove_web_service.UserManagement.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.UserManagement.Infrastructure.Pipeline.Middleware.Extensions;
using ecomove_web_service.UserManagement.Infrastructure.Tokens.JWT.Configuration;
using ecomove_web_service.UserManagement.Infrastructure.Tokens.JWT.Services;
using ecomove_web_service.UserManagement.Interfaces.ACL;
using ecomove_web_service.UserManagement.Interfaces.ACL.Services;
using ecomove_web_service.VehicleManagement.Application.Internal.CommandServices;
using ecomove_web_service.VehicleManagement.Application.Internal.QueryServices;
using ecomove_web_service.VehicleManagement.Domain.Repositories;
using ecomove_web_service.VehicleManagement.Domain.Services;
using ecomove_web_service.VehicleManagement.Infrastructure.Persistence.EFC.Repositories;
using ecomove_web_service.VehicleManagement.Interfaces.ACL;
using ecomove_web_service.VehicleManagement.Interfaces.ACL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure Database Context and Logging Levels

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        if (connectionString != null)
            if (builder.Environment.IsDevelopment())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            else if (builder.Environment.IsProduction())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Error)
                    .EnableDetailedErrors();
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1",
            new OpenApiInfo
            {
                Title = "EcomoveWebService.API",
                Version = "v1",
                Description = "Ecomove Web Service API",
                TermsOfService = new Uri("https://ecomove.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Ecomove",
                    Email = "ecomove@gmail.com"
                }
            });
        c.EnableAnnotations();
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please insert JWT with Bearer into field",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "bearer"
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
    });

builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Shared Bounded Context Injection Configuration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// UserManagement Bounded Context Injection Configuration

// TokenSettings Configuration

builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserCommandService, UserCommandService>();
builder.Services.AddScoped<IUserQueryService, UserQueryService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IHashingService, HashingService>();
builder.Services.AddScoped<ExternalUserService>();
builder.Services.AddScoped<IUserManagementContextFacade, UserManagementContextFacade>();

builder.Services.AddScoped<IMembershipRepository, MembershipRepository>();
builder.Services.AddScoped<IMembershipCommandService, MembershipCommandService>();
builder.Services.AddScoped<IMembershipQueryService, MembershipQueryService>();

builder.Services.AddScoped<IMembershipCategoryRepository, MembershipCategoryRepository>();
builder.Services.AddScoped<IMembershipCategoryCommandService, MembershipCategoryCommandService>();
builder.Services.AddScoped<IMembershipCategoryQueryService, MembershipCategoryQueryService>();

// VehicleManagement Bounded Context Injection Configuration

builder.Services.AddScoped<IEcoVehicleRepository, EcoVehicleRepository>();
builder.Services.AddScoped<IEcoVehicleCommandService, EcoVehicleCommandService>();
builder.Services.AddScoped<IEcoVehicleQueryService, EcoVehicleQueryService>();

builder.Services.AddScoped<IEcoVehicleTypeRepository, EcoVehicleTypeRepository>();
builder.Services.AddScoped<IEcoVehicleTypeCommandService, EcoVehicleTypeCommandService>();
builder.Services.AddScoped<IEcoVehicleTypeQueryService, EcoVehicleTypeQueryService>();
builder.Services.AddScoped<ExternalEcoVehicleService>();
builder.Services.AddScoped<IVehicleManagementContextFacade, VehicleManagementContextFacade>();

// BookingReservation Bounded Context Injection Configuration

builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBookingCommandService, BookingCommandService>();
builder.Services.AddScoped<IBookingQueryService, BookingQueryService>();

// CustomerSupport Bounded Context Injection Configuration

builder.Services.AddScoped<ICustomerSupportAgentRepository, CustomerSupportAgentRepository>();
builder.Services.AddScoped<ICustomerSupportAgentCommandService, CustomerSupportAgentCommandService>();
builder.Services.AddScoped<ICustomerSupportAgentQueryService, CustomerSupportAgentQueryService>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketCommandService, TicketCommandService>();
builder.Services.AddScoped<ITicketQueryService, TicketQueryService>();

builder.Services.AddScoped<ITicketCategoryRepository, TicketCategoryRepository>();
builder.Services.AddScoped<ITicketCategoryCommandService, TicketCategoryCommandService>();
builder.Services.AddScoped<ITicketCategoryQueryService, TicketCategoryQueryService>();

builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionCommandService, TransactionCommandService>();
builder.Services.AddScoped<ITransactionQueryService, TransactionQueryService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRequestAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("Policy");

app.UseAuthorization();

app.MapControllers();

app.Run();