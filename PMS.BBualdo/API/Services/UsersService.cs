using API.Helpers;
using API.Services.DTOs;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class UsersService(UserManager<User> userManager, AccountEmailHelper emailHelper) : IUsersService
{
    private readonly AccountEmailHelper _emailHelper = emailHelper;
    private readonly UserManager<User> _userManager = userManager;

    public async Task<PaginatedUsers> GetUsersAsync(int page, int pageSize)
    {
        var users = await _userManager.Users.Where(u => u.Email != "admin@admin.com").ToListAsync();
        var totalPages = (int)Math.Ceiling((double)users.Count / pageSize);
        var paginatedUsers = users
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return new PaginatedUsers
        {
            Total = totalPages,
            Users = paginatedUsers
        };
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        return await _userManager.FindByIdAsync(id);
    }

    public async Task<bool> AddUserAsync(UserCreateModel model)
    {
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email
        };

        var result = await _userManager.CreateAsync(user, "Test123!");

        if (result.Succeeded)
            await _emailHelper.SendConfirmationEmailAsync(user);

        return result.Succeeded;
    }

    public async Task DeleteUserAsync(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        await _userManager.DeleteAsync(user);
    }

    public async Task<bool> UpdateUserAsync(UpdateUserModel model)
    {
        var user = await _userManager.FindByIdAsync(model.Id);
        if (user == null)
            return false;

        if (user.Email != model.Email)
            await _emailHelper.SendConfirmationEmailAsync(user);

        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.Email = model.Email;
        user.UserName = model.Email;

        var result = await _userManager.UpdateAsync(user);

        return result.Succeeded;
    }
}