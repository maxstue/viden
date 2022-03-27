using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using viden.Infrastructure.Database;

namespace viden.Infrastructure;

public static class ServiceExtension
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services.AddDbContext(configuration)
                // .AddCustomCors()
            // .AddCustomAuthorization(configuration)
            // .AddRepositories()
            // .AddServices()
            // .AddBackgroundServices();
            ;
    }
    
    private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["Infrastructure:ConnectionStrings:sqlConnection"];
        services.AddDbContext<AppDbContext>(builder =>
        {
            builder.UseLazyLoadingProxies();
            // Change to LogLevel.Information or lower wo see the generated sql statements
            builder.LogTo(Console.WriteLine, LogLevel.Error);
            builder.UseNpgsql(connectionString,
                options =>
                {
                    options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                });
        });

        return services;
    }
    
    // private static IServiceCollection AddCustomCors(this IServiceCollection services)
    // {
    //     return services.AddCors(options =>
    //     {
    //         options.AddPolicy(AuthConstants.CorsPolicies.AllowAny,
    //             builder => builder
    //                 .AllowAnyorigin()
    //                 // .WithOrigins("http://localhost:8080", "http://localhost:4200")
    //                 .AllowAnyMethod()
    //                 .AllowAnyHeader());
    //     });
    // }
}