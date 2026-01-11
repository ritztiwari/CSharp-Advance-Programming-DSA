//3.Student Grade Book
//Use Case: Map student roll numbers to their grade report.
//OOP Concepts:
//? Interface: GradeReport
//? Polymorphism: Different grading strategies(CBSE, GPA).
//? Encapsulation: Grade map managed inside grade service.

using System;

interface IGradeReport
{
    string GetMarks(int marks);
}

class CBSE : IGradeReport
{
    public string GetMarks(int marks)
    {
        return marks >= 90 ? "A" : "B";
    }
}

class GPA : IGradeReport
{
    public string GetMarks(int marks)
    {
        return marks >= 90 ? "9.0" : "8.0";
    }
}

internal class GradeBook
{
    Dictionary<string, IGradeReport> dict = new Dictionary<string, IGradeReport>();

    public void AddStudent(string name, IGradeReport marks)
    {
        dict[name] = marks;
    }

    public void ShowGrade(string name, int marks)
    {
        Console.WriteLine($"Grade of {name}: " + dict[name].GetMarks(marks));
    }
}