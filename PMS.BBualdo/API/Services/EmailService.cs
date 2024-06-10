using System.Net.Mail;
using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace API.Services;

public class EmailService(IOptions<EmailOptions> options) : IEmailSender
{
    private readonly EmailOptions _options = options.Value;

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        var sender = new SmtpSender(() =>
            new SmtpClient(_options.SmtpServer, _options.Port)
            {
                EnableSsl = _options.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network
                // UseDefaultCredentials = false,
                // Credentials = new NetworkCredential(_options.Sender, _options.Password)
            });

        Email.DefaultSender = sender;
        Email.DefaultRenderer = new RazorRenderer();

        var email = await Email
            .From(_options.Sender, _options.SenderName)
            .To(toEmail)
            .Subject(subject)
            .UsingTemplate(message, new { }, true)
            .SendAsync();

        if (!email.Successful)
        {
            // log errors
        }
    }
}