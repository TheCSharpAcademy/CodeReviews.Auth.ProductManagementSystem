namespace ProductManagementSystems.tonyissa.Models;

public class ErrorLog
{
    public int Id { get; set; }
    public required DateTime OccurredAt { get; set; }
    public required string Message { get; set; }
    public required string ForUserId { get; set; }
    public required int RelatedItemId { get; set; }
}