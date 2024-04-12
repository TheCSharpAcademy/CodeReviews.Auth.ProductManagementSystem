using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.StevieTV.Models;

namespace ProductManagementSystem.StevieTV.Controllers;

[Authorize(Policy = "Admin")]
public class UserRolesController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UserRolesController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        var userRolesViewModel = new List<UserRolesViewModel>();

        foreach (var user in users)
        {
            var thisViewModel = new UserRolesViewModel()
            {
                UserId = user.Id,
                Email = user.Email,
                Roles = await GetUserRoles(user)
            };
            userRolesViewModel.Add(thisViewModel);
        }

        return View(userRolesViewModel);
    }

    private async Task<IEnumerable<string>> GetUserRoles(IdentityUser user)
    {
        return new List<string>(await _userManager.GetRolesAsync(user));
    }
    
    public async Task<IActionResult> Manage(string userId)
    {
        ViewData["UserId"] = userId;

        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            ViewData["ErrorMessage"] = $"User with Id = {userId} cannot be found";
            return NotFound();
        }

        var model = new List<ManageUserRolesViewModel>();

        foreach (var role in _roleManager.Roles)
        {
            var userRolesViewModel = new ManageUserRolesViewModel()
            {
                RoleId = role.Id,
                RoleName = role.Name,
                Selected = await _userManager.IsInRoleAsync(user, role.Name)
            };
            model.Add(userRolesViewModel);
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Manage(List<ManageUserRolesViewModel> model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return View();

        var roles = await _userManager.GetRolesAsync(user);
        var result = await _userManager.RemoveFromRolesAsync(user, roles);

        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Cannot remove user from existing roles");
            return View(model);
        }

        result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));

        if (!result.Succeeded)
        {
            ModelState.AddModelError("","Cannot add selected roles to user");
            return View(model);
        }

        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(string? userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            return NotFound();
        }

        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user != null)
        {
            await _userManager.DeleteAsync(user);
        }

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(string? userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            return NotFound();
        }

        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,Email,EmailConfirmed")] IdentityUser user)
    {
        if (id != user.Id)
        {
            return NotFound();
        }
        
        if (string.IsNullOrEmpty(id))
        {
            return NotFound();
        }

        var userToUpdate = await _userManager.FindByIdAsync(id);

        if (userToUpdate == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            
            userToUpdate.UserName = user.UserName;
            userToUpdate.Email = user.Email;
            userToUpdate.EmailConfirmed = user.EmailConfirmed;
            await _userManager.UpdateAsync(userToUpdate);
            
            return RedirectToAction(nameof(Index));
        }

        return View(user);
    }
}