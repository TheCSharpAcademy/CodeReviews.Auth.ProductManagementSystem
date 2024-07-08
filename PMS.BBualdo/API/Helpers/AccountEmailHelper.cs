using System.Text;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace API.Helpers;

public class AccountEmailHelper(IEmailSender emailSender, UserManager<User> userManager)
{
    private readonly IEmailSender _emailSender = emailSender;
    private readonly UserManager<User> _userManager = userManager;

    public async Task SendConfirmationEmailAsync(User user)
    {
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var confirmationLink = $"http://localhost:4200/email-confirmation/?userId={user.Id}&token={token}";

        StringBuilder template = new();
        template.Append($"<p>Hello {user.FirstName},</p>");
        template.Append("<p>Thank you for registering on Product Management System platform.</p>");
        template.Append("<p>One last step is to confirm your email. You can do that by clicking in this link:</p>");
        template.Append($"<a href={confirmationLink}>Link</a>");
        template.Append("<p>Best regards, PMS Support.</p>");

        await _emailSender.SendEmailAsync(user.Email!, "Email confirmation", template.ToString());
    }

    public async Task SendPasswordRecoveryEmailAsync(User user)
    {
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var passwordRecoveryLink = $"http://localhost:4200/password-recovery/?email={user.Email}&token={token}";

        StringBuilder template = new();
        template.Append($"<p>Hello {user.FirstName},</p>");
        template.Append("<p>Here is your link to reset your password:</p>");
        template.Append($"<a href={passwordRecoveryLink}>Link</a>");
        template.Append("<p>If you didn't ask for password recovery then just ignore that message.</p>");
        template.Append("<p>Best regards, PMS Support.</p>");

        await _emailSender.SendEmailAsync(user.Email!, "Password reset", template.ToString());
    }
}