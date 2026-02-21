namespace CareerBridge.Api.Entities;

public class Job
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Location { get; set; }
    public string? Salary { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}
