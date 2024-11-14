using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using ProductManagementSystems.tonyissa.Models;
using System.Net.Http.Headers;

namespace ProductManagementSystems.tonyissa.Services;

public class EmailSender : IEmailSender
{
    private readonly ZohoSettings _settings;
    private string _accessToken = string.Empty;
    private DateTime _expirationTime;
    private readonly HttpClient _httpClient = new();

    public EmailSender(IOptions<ZohoSettings> settings) =>
        _settings = settings.Value;

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var accessToken = await GetAccessToken();
        
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Zoho-oauthtoken", accessToken);

        var emailContent = new
        {
            fromAddress = _settings.EmailAddress,
            toAddress = email,
            subject = subject,
            content = htmlMessage
        };

        var response = await _httpClient.PostAsJsonAsync($"https://mail.zoho.com/api/accounts/{_settings.AccountID}/messages", emailContent);
        response.EnsureSuccessStatusCode();
    }

    private async Task<string> GetAccessToken()
    {
        if (TokenIsValid())
        {
            return _accessToken;
        }

        var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.zoho.com/oauth/v2/token");

        request.Content = new FormUrlEncodedContent(
        [
            new KeyValuePair<string, string>("refresh_token", _settings.RefreshToken),
            new KeyValuePair<string, string>("client_id", _settings.ClientId),
            new KeyValuePair<string, string>("client_secret", _settings.ClientSecret),
            new KeyValuePair<string, string>("grant_type", "refresh_token"),
        ]);

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        _expirationTime = DateTime.UtcNow.AddHours(1);

        var responseBody = await response.Content.ReadFromJsonAsync<ZohoTokenResponse>();
        _accessToken = responseBody!.AccessToken;

        return _accessToken;
    }

    private bool TokenIsValid()
    {
        return !string.IsNullOrEmpty(_accessToken) && DateTime.UtcNow < _expirationTime;
    }
}