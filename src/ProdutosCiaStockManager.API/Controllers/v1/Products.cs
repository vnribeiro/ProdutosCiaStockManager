using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ProdutosCiaStockManager.API.Controllers.v1;

[ApiController]
[ApiVersion(1.0)]
[Route("api/v{apiVersion:apiVersion}/products")]
public class Products : MainController
{
    private readonly ILogger<Products> _logger;

    public Products(ILogger<Products> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        _logger.LogInformation("Getting all products");
        return Ok();
    }
}