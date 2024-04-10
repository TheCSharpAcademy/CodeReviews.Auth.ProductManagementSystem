namespace ProductManagementSystem.StevieTV.Models;

public class VideoGame
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public DateOnly DateAdded { get; set; }
    public decimal Price { get; set; }
}