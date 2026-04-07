/// <summary>
/// Represents a student with a list of grade entries.
/// </summary>
public class Student
{
    public string Name { get; set; } = string.Empty;
    public List<GradeEntry> Grades { get; set; } = new List<GradeEntry>();

    public Student(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Calculates the average score across all grades.
    /// </summary>
    public double GetAverage()
    {
        if (Grades.Count == 0) return 0;
        double total = 0;
        foreach (var grade in Grades)
            total += grade.Score;
        return total / Grades.Count;
    }

    /// <summary>
    /// Returns a letter grade based on the average score.
    /// </summary>
    public string GetLetterGrade()
    {
        double avg = GetAverage();
        if (avg >= 90) return "A";
        if (avg >= 80) return "B";
        if (avg >= 70) return "C";
        if (avg >= 60) return "D";
        return "F";
    }
}