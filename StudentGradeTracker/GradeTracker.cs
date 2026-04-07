using System.Text.Json;
// Manages all the students and handles their file persistence
public class GradeTracker
{
    private List<Student> students = new List<Student>();
    private const string FilePath = "grades.json";

    // Loads student data from JSON file on startup
    public void LoadData()
    {
        try
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
        }
    }
    // Saves student data to JSON file on exit
    public void SaveData()
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText(FilePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }
    // Adds a new student to the system
public void AddStudent(string name)
{
    var existing = students.Find(s => s.Name.ToLower() == name.ToLower());
    if (existing != null)
    {
        Console.WriteLine($"Student '{name}' already exists.");
        return;
    }
    students.Add(new Student(name));
    SaveData();
    Console.WriteLine($"Student '{name}' added successfully.");
}
    // Adds a grade for an existing student or creates a new student if not found
    public void AddGrade(string studentName, string subject, double score)
    {
        var student = students.FindLast(s=> s.Name.ToLower() == studentName.ToLower());
        if (student == null)
        {
            Console.WriteLine($"Student '{studentName}' not found. Creating new student.");
            return;
        }
        student.Grades.Add(new GradeEntry(subject, score));
        SaveData();
        Console.WriteLine($"Grade added for {studentName} in {subject} with score {score}");
    }
    // Displays a full grade report for a specific student
    
    public void ViewReport(string studentName)
    {
        var student = students.Find(s => s.Name.ToLower() == studentName.ToLower());
        if (student == null)
        {
            Console.WriteLine($"Student '{studentName}' not found.");
            return;
        }
        Console.WriteLine($"\nGrade Report for {student.Name}:");
        if (student.Grades.Count == 0)
        {
            Console.WriteLine("No grades recorded yet.");
            return;
        }
        foreach (var grade in student.Grades)
        {
            Console.WriteLine($"- {grade.Subject}: {grade.Score} ");
        }
    Console.WriteLine($" ------------------------------------");
        Console.WriteLine($"Average Score: {student.GetAverage():F2}");
        Console.WriteLine($"Letter Grade: {student.GetLetterGrade()}");
        Console.WriteLine($"=====================================");
    }
    // list all students in the system
    public void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }
          Console.WriteLine("\n====== All Students ======");
        foreach (var s in students)
            Console.WriteLine($"  {s.Name} | Avg: {s.GetAverage():F2} | Grade: {s.GetLetterGrade()}");
        Console.WriteLine("==========================");
    }

}