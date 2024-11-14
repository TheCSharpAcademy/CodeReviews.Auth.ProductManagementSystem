using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductManagementSystems.tonyissa.Areas.Identity.Pages.Account
{
    public class UpgradeModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public bool? IsUpgradeSuccessful { get; set; }

        public UpgradeModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null || await _userManager.IsInRoleAsync(user, "Admin"))
            {
                IsUpgradeSuccessful = false;
                return Page();
            }

            var result = await _userManager.AddToRoleAsync(user, "Admin");

            if (result.Succeeded)
            {
                IsUpgradeSuccessful = true;
            }
            else
            {
                IsUpgradeSuccessful = false;
            }

            await _signInManager.RefreshSignInAsync(user);

            return Page();
        }
    }
}
