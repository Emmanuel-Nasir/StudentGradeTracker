var tracker = new GradeTracker();
tracker.LoadData();

SimpleGrade demoGrade;
demoGrade.Subject = "Demo";
demoGrade.Score = 100;

Console.WriteLine($"Struct Demo: {demoGrade.Subject} - {demoGrade.Score}");

bool running = true;

while (running)
{
    Console.WriteLine("\n==============================");
    Console.WriteLine("   Student Grade Tracker");
    Console.WriteLine("==============================");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Grade");
    Console.WriteLine("3. View Student Report");
    Console.WriteLine("4. List All Students");
    Console.WriteLine("5. Exit");
    Console.WriteLine("==============================");
    Console.Write("Choose an option (1-5): ");

    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("Enter student name: ");
            string name = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(name))
                tracker.AddStudent(name);
            else
                Console.WriteLine("Name cannot be empty.");
            break;

        case "2":
            Console.Write("Enter student name: ");
            string sName = Console.ReadLine() ?? "";
            Console.Write("Enter subject: ");
            string subject = Console.ReadLine() ?? "";
            Console.Write("Enter score (0-100): ");
            if (double.TryParse(Console.ReadLine(), out double score)
                && score >= 0 && score <= 100)
                tracker.AddGrade(sName, subject, score);
            else
                Console.WriteLine("Invalid score. Enter a number between 0 and 100.");
            break;

        case "3":
            Console.Write("Enter student name: ");
            string rName = Console.ReadLine() ?? "";
            tracker.ViewReport(rName);
            break;

        case "4":
            tracker.ListStudents();
            break;

        case "5":
            running = false;
            Console.WriteLine("\nGoodbye! See you next time.");
            break;

        default:
            Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
            break;
    }
}