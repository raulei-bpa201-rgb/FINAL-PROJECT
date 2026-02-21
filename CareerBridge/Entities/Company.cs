namespace CareerBridge.Api.Entities;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Website { get; set; }

    public ICollection<Job> Jobs { get; set; } = new List<Job>();
}
