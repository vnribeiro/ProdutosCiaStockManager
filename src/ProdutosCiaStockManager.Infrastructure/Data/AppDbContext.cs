using Microsoft.EntityFrameworkCore;

namespace ProdutosCiaStockManager.Infrastructure.Data;

public class AppDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppDbContext"/> class.
    /// </summary>
    /// <param name="dbContextOptions">The options to be used by the DbContext.</param>
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) {}

    /// <summary>
    /// Configures the model that was discovered by convention from the entity types
    /// exposed in <see cref="DbSet{TEntity}"/> properties on your derived context.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Padronize all string properties
        // to be of type varchar(100)
        ConfigureStringProperties(modelBuilder);

        // Apply configurations from the assembly where configuration classes are located
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    /// <summary>
    /// Sets all string properties to be of type varchar(100).
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
    private static void ConfigureStringProperties(ModelBuilder modelBuilder)
    {
        foreach (var property in modelBuilder.Model
                     .GetEntityTypes()
                     .SelectMany(e => e.GetProperties()
                         .Where(p => p.ClrType == typeof(string))))

            property.SetColumnType("varchar(100)");
    }
}