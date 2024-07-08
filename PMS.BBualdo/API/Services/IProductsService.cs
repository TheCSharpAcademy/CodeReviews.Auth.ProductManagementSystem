using API.Services.DTOs;
using Data.Models;

namespace API.Services;

public interface IProductsService
{
    Task<PaginatedProducts> GetProductsAsync(int page, int pageSize);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}