using Asp.Versioning.ApiExplorer;
using ProdutosCiaStockManager.API.Extensions;
using ProdutosCiaStockManager.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure environment settings
// and PostgreSQL for data storage
builder
    .ConfigureEnvironmentSettings()
    .ConfigurePostgreSql();

// Add API versioning
// nd Swagger configuration
builder
    .Services
    .ConfigureApiVersioning()
    .ConfigureSwagger();

// Add Repositories and Services
builder
    .Services
    .AddRepositories()
    .AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    // Configure SwaggerUI to show all APIS versions
    app.UseSwaggerUI(options =>
    {
        var provider = app.Services
            .GetRequiredService<IApiVersionDescriptionProvider>();

        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", 
                $"Produtos & CIA API {description.GroupName.ToUpperInvariant()}");
        }
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Register middleware for handling exceptions
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();