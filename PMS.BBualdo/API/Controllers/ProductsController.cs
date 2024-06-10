using API.Services;
using API.Services.DTOs;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductsService productsService) : ControllerBase
{
    private readonly IProductsService _productsService = productsService;

    [HttpGet]
    [Authorize]
    public async Task<ActionResult<PaginatedProducts>> GetProducts(int page = 1, int pageSize = 5)
    {
        var products = await _productsService.GetProductsAsync(page, pageSize);
        return Ok(products);
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult> AddProduct(Product product)
    {
        await _productsService.AddProductAsync(product);
        return CreatedAtAction(nameof(AddProduct), product);
    }

    [HttpPut]
    [Authorize]
    public async Task<ActionResult> UpdateProduct(Product product)
    {
        await _productsService.UpdateProductAsync(product);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    [Authorize]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        await _productsService.DeleteProductAsync(id);
        return NoContent();
    }
}