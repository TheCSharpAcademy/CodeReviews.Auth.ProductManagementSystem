using API.Services;
using API.Services.DTOs;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUsersService usersService) : ControllerBase
{
    private readonly IUsersService _usersService = usersService;

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<PaginatedUsers>> GetUsers(int page = 1, int pageSize = 5)
    {
        var users = await _usersService.GetUsersAsync(page, pageSize);
        return Ok(users);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> AddUser(UserCreateModel model)
    {
        var isSuccessful = await _usersService.AddUserAsync(model);
        if (!isSuccessful)
            return BadRequest(new[]
                { new { code = "UserAlreadyExists", description = "User with that email address already exists." } });
        return CreatedAtAction(nameof(AddUser), model);
    }

    [HttpPut]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> UpdateUser( UpdateUserModel model)
    {
        var isSuccessful = await _usersService.UpdateUserAsync(model);
        if (!isSuccessful)
            return BadRequest(new[] { new { code = "UpdateFailed", description = "User update failed." } });
        return NoContent();
    }

    [HttpDelete]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> DeleteUser(string id)
    {
        await _usersService.DeleteUserAsync(id);
        return NoContent();
    }
}