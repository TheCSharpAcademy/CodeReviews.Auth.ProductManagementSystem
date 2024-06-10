using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Data.Models;

public class User : IdentityUser
{
    [Required] [StringLength(50)] public string? FirstName { get; set; }
    [Required] [StringLength(50)] public string? LastName { get; set; }
}