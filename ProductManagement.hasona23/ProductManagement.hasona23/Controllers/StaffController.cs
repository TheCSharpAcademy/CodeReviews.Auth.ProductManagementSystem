using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagement.hasona23.Data;
using ProductManagement.hasona23.Models;

namespace ProductManagement.hasona23.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public StaffController(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }



        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        
        // GET: Books/Promote/5
        public async Task<IActionResult> Promote(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if (!await _userManager.IsInRoleAsync(user, "Staff"))
            {
                var result = await _userManager.AddToRoleAsync(user, "Staff");
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Failed to promote the user.");
                    return View("Error"); // Optionally, show an error view.
                }
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Demote(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if (await _userManager.IsInRoleAsync(user, "Staff"))
            {
                var result = await _userManager.RemoveFromRoleAsync(user, "Staff");
                if (!await _userManager.IsInRoleAsync(user, "Customer"))
                {
                    await _userManager.AddToRoleAsync(user, "Customer");
                }
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Failed to demote the user.");
                    return View("Error"); // Optionally, show an error view.
                }
            }

            return RedirectToAction(nameof(Index));
        }

       
        // GET: Books/Delete/5
        
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Failed to delete the user.");
                return View("Error"); // Optionally, show an error view.
            }

            return RedirectToAction(nameof(Index));
        }

        
    }
}
