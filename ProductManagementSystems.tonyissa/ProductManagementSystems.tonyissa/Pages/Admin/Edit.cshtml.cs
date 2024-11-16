using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductManagementSystems.tonyissa.Pages.Admin
{
    public class EditModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public EditModel(UserManager<IdentityUser> userManager)
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

            if (user.EmailConfirmed != SelectedUser.EmailConfirmed)
            {
                var emailConfirmToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _userManager.ConfirmEmailAsync(user, emailConfirmToken);
            }

            if (user.Email != SelectedUser.Email)
            {
                var emailChangeToken = await _userManager.GenerateChangeEmailTokenAsync(user, SelectedUser.Email);
                await _userManager.ChangeEmailAsync(user, SelectedUser.Email, emailChangeToken);
            }

            return RedirectToPage("./Index", new { error = false, message = "Operation executed successfully" });
        }
    }
}
