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
    public decimal? Price { get; set; }
    [StringLength(50, MinimumLength = 1)]
    public string Developer { get; set; } = string.Empty;
    [StringLength(50)]
    public string? Publisher { get; set; } = string.Empty;
    [Display(Name = "Release Date (USA)")]
    [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
    public DateTime USAReleaseDate { get; set; }
    [RegularExpression("^[A-Z][a-z]*$")]
    [StringLength(25)]
    public string Genre { get; set; } = string.Empty;
}