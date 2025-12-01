using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> empList = new()
        {
            new Employee(){Name="A", Dept="IT", Salary=50000},
            new Employee(){Name="B", Dept="HR", Salary=30000},
            new Employee(){Name="C", Dept="IT", Salary=60000}
        };

        var result = empList
                        .Where(e => e.Dept == "IT")
                        .OrderBy(e => e.Salary);

        foreach (var e in result)
            Console.WriteLine($"{e.Name} - {e.Salary}");
    }
}
