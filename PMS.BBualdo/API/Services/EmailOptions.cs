namespace API.Services;

public class EmailOptions
{
    public string? SmtpServer { get; set; }
    public int Port { get; set; }
    public bool EnableSsl { get; set; }
    public string? Sender { get; set; }
    public string? SenderName { get; set; }
    public string? Password { get; set; }
}