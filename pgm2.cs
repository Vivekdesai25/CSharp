using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static double CalculateAverage(List<Student> students)
    {
        double total = 0;
        foreach (var s in students)
            total += s.Grade;

        return total / students.Count;
    }

    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student(){Name="A", Age=20, Grade=85},
            new Student(){Name="B", Age=21, Grade=90},
            new Student(){Name="C", Age=19, Grade=88}
        };

        Console.WriteLine("Average Grade = " + CalculateAverage(students));
    }
}
