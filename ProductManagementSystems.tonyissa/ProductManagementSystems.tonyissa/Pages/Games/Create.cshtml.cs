using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductManagementSystems.tonyissa.Data;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductManagementSystems.tonyissa.Data.ApplicationDbContext _context;

        public CreateModel(ProductManagementSystems.tonyissa.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Games.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
