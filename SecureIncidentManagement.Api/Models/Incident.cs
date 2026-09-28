namespace SecureIncidentManagement.Api.Models;
public class Incident
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = "Low";
    public string Status { get; set; } = "Open";
    public int CreatedById { get; set; }
    public User CreatedBy { get; set; } = null!;
    public int? AssignedToId { get; set; }
    public User? AssignedTo { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
} 