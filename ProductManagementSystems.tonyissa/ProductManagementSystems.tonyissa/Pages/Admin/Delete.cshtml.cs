using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProductManagementSystems.tonyissa.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public IdentityUser SelectedUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            SelectedUser = await _userManager.FindByIdAsync(id);

            if (SelectedUser == null)
                return NotFound();

            if (SelectedUser.Id == _userManager.GetUserId(User))
                return RedirectToPage("./Index", new { error = true, message = "Cannot edit/delete your own account" });

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null) 
                return NotFound();

            await _userManager.DeleteAsync(user);

            return RedirectToPage("./Index", new { error = false, message = "Operation executed successfully" });
        }
    }
}
