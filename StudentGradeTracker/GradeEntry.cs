/// <summary>
/// Represents a single grade entry for a subject.
/// </summary>
public class GradeEntry
{
    public string Subject { get; set; } = string.Empty;
    public double Score { get; set; }

    public GradeEntry(string subject, double score)
    {
        Subject = subject;
        Score = score;
    }
}