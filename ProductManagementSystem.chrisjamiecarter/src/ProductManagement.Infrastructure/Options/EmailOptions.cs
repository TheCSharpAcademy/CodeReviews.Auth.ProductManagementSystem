﻿namespace ProductManagement.Infrastructure.Options;

/// <summary>
/// Defines the application email requirements.
/// </summary>
internal class EmailOptions
{
    public string SmtpHost { get; set; } = string.Empty;

    public int SmtpPort { get; set; }

    public string SmtpUser { get; set; } = string.Empty;

    public string SmtpPassword { get; set; } = string.Empty;

    public string FromName { get; set; } = string.Empty;

    public string FromEmailAddress { get; set; } = string.Empty;
}
