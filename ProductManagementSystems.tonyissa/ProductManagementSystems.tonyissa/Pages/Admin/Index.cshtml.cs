using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductManagementSystems.tonyissa.Pages.Admin;

public class IndexModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;

    public IndexModel(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

	[BindProperty]
	public bool? Error { get; set; }
    [BindProperty]
    public string? ErrorMessage { get; set; }
    [BindProperty]
    public List<IdentityUser> Users { get; set; } = default!;

    public IActionResult OnGet(bool? error, string? message)
    {
        Users = _userManager.Users.ToList();
        Error = error;
        ErrorMessage = message;

		return Page();
    }
}