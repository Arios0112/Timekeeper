namespace Timekeeper.Web.Models;

public class TimeEntry
{
    public required string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Comment { get; set; } = string.Empty;
    public bool IsSickLeave { get; set; }

    public TimeSpan Duration => (EndDate ?? DateTime.UtcNow) - StartDate;
}
