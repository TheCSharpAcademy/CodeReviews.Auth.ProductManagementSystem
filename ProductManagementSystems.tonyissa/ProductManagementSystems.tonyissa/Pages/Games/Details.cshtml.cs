using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystems.tonyissa.Data;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ProductManagementSystems.tonyissa.Data.ApplicationDbContext _context;

        public DetailsModel(ProductManagementSystems.tonyissa.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }
            else
            {
                Game = game;
            }
            return Page();
        }
    }
}
