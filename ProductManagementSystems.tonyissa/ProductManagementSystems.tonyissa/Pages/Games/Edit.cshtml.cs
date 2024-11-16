using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystems.tonyissa.Data;
using ProductManagementSystems.tonyissa.Models;

namespace ProductManagementSystems.tonyissa.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EditModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public EditModel(ApplicationDbContext context, ILogger<EditModel> logger, UserManager<IdentityUser> userManager)
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

            var game =  await _context.Games.FirstOrDefaultAsync(m => m.ID == id);
            if (game == null)
            {
                return NotFound();
            }
            Game = game;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!GameExists(Game.ID))
                {
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "An error has occured while trying to update a game");

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

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.ID == id);
        }
    }
}
