using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class ErrorLog
{
    [Key] public int Id { get; set; }
    public string? Message { get; set; }
    public DateTime Time { get; set; }
}