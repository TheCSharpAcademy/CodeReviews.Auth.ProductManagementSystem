using Data.Models;

namespace API.Services.DTOs;

public class PaginatedProducts
{
    public int Total { get; set; }
    public IEnumerable<Product> Products { get; set; }
}