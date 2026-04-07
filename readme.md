# Overview


As a software engineer continuously working to expand my technical skill set,
I challenged myself to learn C# by building a meaningful, functional application
from scratch. My goal was to gain practical experience with C#'s object-oriented
design, strongly-typed collections, and file persistence — core competencies that
apply directly to professional software development.

The software I built is a Student Grade Tracker — a console application written
in C# that allows a user to input assignment grades across multiple courses,
automatically calculates course averages and an overall GPA, and saves and loads
all data to and from a file so that records persist between sessions.

My purpose for writing this software was to move beyond basic syntax exercises
and engage with a real problem that required me to use C# classes, lists,
loops, file I/O, and LINQ all working together. The grade tracker gave me a
focused, practical target that touched the most important parts of the language
in one project.

[Software Demo Video](http://youtube.link.goes.here)

# Development Environment

- **IDE:** Visual Studio Code with the C# Dev Kit extension
- **Runtime:** .NET SDK (dotnet CLI for building and running)
- **Version Control:** Git / GitHub

The project is written entirely in **C#** using the **.NET** framework. No
third-party libraries were used. The application relies on the standard .NET
base class library — specifically `System.IO` for saving and loading grade data,
`System.Collections.Generic` for managing courses and assignments, and
`System.Linq` for computing averages and GPA calculations.
# Useful Websites

{Make a list of websites that you found helpful in this project}

- [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [W3Schools C# Tutorial](https://www.w3schools.com/cs/index.php)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/c%23)
- [C# Station](http://www.csharp-station.com/Tutorial.aspx)
# Future Work

- Add weighted grades so exams and quizzes count differently than homework
- Display letter grades (A, B, C, D, F) alongside numeric averages
- Build a GUI using Windows Forms or WPF to replace the console interface