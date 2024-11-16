using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystems.tonyissa.Models;

public class Game
{
    public int ID { get; set; }
    [Display(Name = "Game")]
    [StringLength(50, MinimumLength = 1)]
    public string Name { get; set; } = string.Empty;
    [StringLength(1000, MinimumLength = 1)]
    public string Description { get; set; } = string.Empty;
    [Display(Name = "Price (USD)")]
    [Range(0.01, 999.99)]
    [Precision(5, 2)]
    [DataType(DataType.Currency)]
    public decimal? Price { get; set; }
    [StringLength(50, MinimumLength = 1)]
    public string Developer { get; set; } = string.Empty;
    [StringLength(25, MinimumLength = 1)]
    public string Platform { get; set; } = string.Empty;
    [Display(Name = "Release Date (USA)")]
    [DataType(DataType.Date)]
    public DateTime USAReleaseDate { get; set; }
    [RegularExpression("^[A-Z][a-zA-Z\\s-]*$", ErrorMessage = "Genre should only contain letters, dashes, or spaces, and first letter should be capital")]
    [StringLength(30, MinimumLength = 1)]
    public string Genre { get; set; } = string.Empty;
}