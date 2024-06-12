using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ProductManagementSystem.StevieTV.Helpers;

public class EmailService : IEmailSender
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailService> _logger;

    public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        var emailConfig = _configuration.GetSection("Email");
        _logger.LogInformation("Sending Mail");

        await ExecuteAsync(emailConfig, toEmail, subject, message);
    }

    public async Task ExecuteAsync(IConfigurationSection emailConfig, string toEmail, string subject, string message)
    {
        using var mail = new MailMessage();

        mail.From = new MailAddress(emailConfig.GetValue<string>("Sender"), emailConfig.GetValue<string>("DisplayName"));
        mail.To.Add(toEmail);
        mail.Subject = subject;
        mail.Body = message;
        mail.IsBodyHtml = true;
        
        _logger.LogDebug($"Sending mail to {mail.To} from {mail.From} with subject {mail.Subject}");

        using var smtpClient = new SmtpClient(
            emailConfig.GetValue<string>("SmtpServer"),
            emailConfig.GetValue<int>("PortNumber"));

        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.UseDefaultCredentials = false;
        
        smtpClient.Credentials = new NetworkCredential(
            emailConfig.GetValue<string>("Sender"),
            emailConfig.GetValue<string>("Password"));
        
        smtpClient.EnableSsl = emailConfig.GetValue<bool>("EnableSSL");
        
        _logger.LogTrace($"connecting to {smtpClient.Host}:{smtpClient.Port}");
        
        smtpClient.Send(mail);
    }
}