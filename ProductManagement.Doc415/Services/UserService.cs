using ProductManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Services;

public class UserService
{
    private readonly  ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ApplicationUser>> GetUsers()
    {
        return await _context.AspNetUsers.ToListAsync();
    }
}