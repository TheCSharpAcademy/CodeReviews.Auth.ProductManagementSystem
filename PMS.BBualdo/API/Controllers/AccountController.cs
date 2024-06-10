using API.Helpers;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(
    SignInManager<User> signInManager,
    UserManager<User> userManager,
    AccountEmailHelper emailHelper) : ControllerBase
{
    private readonly AccountEmailHelper _emailHelper = emailHelper;
    private readonly SignInManager<User> _signInManager = signInManager;
    private readonly UserManager<User> _userManager = userManager;

    [HttpGet("currentUser")]
    public async Task<ActionResult> GetCurrentUser()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return NoContent();
        var roles = await _userManager.GetRolesAsync(user);
        return Ok(new
        {
            userId = user.Id,
            firstName = user.FirstName,
            lastName = user.LastName,
            email = user.Email,
            roles
        });
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterModel model)
    {
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password!);

        if (!result.Succeeded)
            return Conflict(result.Errors);

        await _userManager.AddToRoleAsync(user, "Staff Member");

        await _emailHelper.SendConfirmationEmailAsync(user);

        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email!);
        if (user == null)
            return Conflict(new[]
                { new { code = "UserNotFound", description = "No user with given e-mail address." } });

        var result = await _signInManager.PasswordSignInAsync(user, model.Password!, false, false);

        if (result.Succeeded)
            return Ok(result);
        return Unauthorized(result.IsNotAllowed
            ? new[] { new { code = "NotAllowed", description = "Before you sign in you have to confirm your email." } }
            : new[] { new { code = "LoginFailed", description = "Login attempt failed!" } });
    }

    [HttpPost("logout")]
    public async Task<ActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return NoContent();
    }

    [HttpGet("confirmEmail")]
    public async Task<ActionResult> ConfirmEmail(string userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return NotFound("User doesn't exist.");

        if (user.EmailConfirmed)
            return NoContent();

        // Url Encoding and Decoding workaround
        token = token.Replace(" ", "+");

        var result = await _userManager.ConfirmEmailAsync(user, token);

        if (!result.Succeeded)
            return Unauthorized(result.Errors);

        return Ok("Email confirmed.");
    }

    [HttpPost("resendConfirmationEmail")]
    public async Task<ActionResult> ResendConfirmationEmail(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
            // Don't notify that user doesn't exist
            await _emailHelper.SendConfirmationEmailAsync(user);

        return Ok("Email confirmation link sent. Check your inbox.");
    }

    [HttpPost("forgotPassword")]
    public async Task<ActionResult> ForgotPassword(PasswordForgotReq req)
    {
        var user = await _userManager.FindByEmailAsync(req.Email!);
        if (user != null)
            // Don't notify that user doesn't exist
            await _emailHelper.SendPasswordRecoveryEmailAsync(user);

        return Ok("Password reset email sent. Please check your inbox.");
    }

    [HttpPost("resetPassword")]
    public async Task<ActionResult> ResetPassword(
        [FromQuery] string token,
        [FromBody] PasswordResetModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email!);
        if (user == null)
            return BadRequest(new[] { new { code = "RecoveryFailure", description = "Changing password failed." } });

        token = token.Replace(" ", "+");

        var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword!);

        if (!result.Succeeded)
            return BadRequest(new[] { new { code = "RecoveryFailure", description = "Password recovery failed." } });

        return Ok(new { message = "Password has been changed!" });
    }
}