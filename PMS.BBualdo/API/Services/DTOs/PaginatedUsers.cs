using Data.Models;

namespace API.Services.DTOs;

public class PaginatedUsers
{
    public int Total { get; set; }
    public IEnumerable<User> Users { get; set; }
}