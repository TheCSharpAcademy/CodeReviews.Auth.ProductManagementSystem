using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Product
{
    [Key] public int Id { get; set; }
    [Required] [StringLength(200)] public string? Name { get; set; }
    [Required] public double Price { get; set; }
    [Required] public DateTime DateAdded { get; set; }
    [Required] public bool IsActive { get; set; }
}