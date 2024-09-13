namespace ProdutosCiaStockManager.API.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds repository services to the IServiceCollection.
    /// </summary>
    /// <param name="services">The IServiceCollection to add services to.</param>
    /// <returns>The IServiceCollection with the added services.</returns>
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // Unit of work is registered as a scoped service.
        //services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

    /// <summary>
    /// Adds services to the IServiceCollection.
    /// </summary>
    /// <param name="services">The IServiceCollection to add services to.</param>
    /// <returns>The IServiceCollection with the added services.</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services;
    }
}