using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProductManagementSystem.StevieTV.Models;

public class VideoGame
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    [Display(Name = "Active?")]
    public bool IsActive { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Date Added")]
    public DateOnly DateAdded { get; set; }
    [DataType(DataType.Currency)]
    [Precision(10,2)]
    public decimal Price { get; set; }
}