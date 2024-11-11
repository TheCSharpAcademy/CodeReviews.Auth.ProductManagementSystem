using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystems.tonyissa.Data;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Games { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Games = await _context.Games.ToListAsync();
        }
    }
}
