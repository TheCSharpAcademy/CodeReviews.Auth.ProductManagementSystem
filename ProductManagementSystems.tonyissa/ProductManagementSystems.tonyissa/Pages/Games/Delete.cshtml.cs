using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystems.tonyissa.Data;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DeleteModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public DeleteModel(ApplicationDbContext context, ILogger<DeleteModel> logger, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                try
                {
                    Game = game;
                    _context.Games.Remove(Game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogError(ex, "An error has occured while trying to delete a game");

                    var errorLog = new ErrorLog
                    {
                        OccurredAt = DateTime.Now,
                        ForUserId = _userManager.GetUserId(User)!,
                        Message = ex.Message,
                        RelatedItemId = Game.ID
                    };

                    _context.Errors.Add(errorLog);
                    await _context.SaveChangesAsync();

                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
