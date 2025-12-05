Program-5: Create a program to read data from a text file and display the content. Then, implement JSON serialization to save the data into a new file.
using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
            {

        string inputFile = @"C:\Users\ADMIN\Desktop\input.txt.";
        string outputFile = @"C:\Users\ADMIN\Desktop\output.json";

        try
        {
            // Check if input file exists
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Input file not found: " + inputFile);
                return;
            }

            // 1. Read content from input file
            string content = File.ReadAllText(inputFile);

            // 2. Display file content
            Console.WriteLine("Content of input.txt:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(content);

            // 3. Prepare data to serialize
            var jsonData = new
            {
                FileName = inputFile,
                TextContent = content,
                SavedOn = DateTime.Now
            };

            // 4. Serialize to JSON (using Newtonsoft.Json)
            string jsonString = JsonConvert.SerializeObject(jsonData, Formatting.Indented);

            // 5. Save json to output file
            File.WriteAllText(outputFile, jsonString);

            Console.WriteLine("\nJSON successfully saved to: " + outputFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }    }  }

Program-6: Write a C# program to demonstrate the use of generic collections by creating a List to store and retrieve product details like Product_ID, Name, and Price.
using System;
using System.Collections.Generic;
class Product
{
    public int Product_ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {Product_ID}, Name: {Name}, Price: {Price}");
    }
}

class Program
{
    static void Main()
    {
        // Create a generic List<Product>
        List<Product> products = new List<Product>();

        // Add product details to the list
        products.Add(new Product { Product_ID = 101, Name = "Laptop", Price = 55000 });
        products.Add(new Product { Product_ID = 102, Name = "Mouse", Price = 500 });
        products.Add(new Product { Product_ID = 103, Name = "Keyboard", Price = 1500 });

        // Display all products
        Console.WriteLine("Product Details (Using List<T>):");
        Console.WriteLine("--------------------------------");

        foreach (var p in products)
        {
            p.Display();
        }
    }
}

Program-7: Use LINQ to query a list of employees, filtering by a specific department and sorting by employee salary. Display the filtered and sorted data on the console.
using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQEmployeeExample
{
    // Employee class
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmpID = 1, Name = "John",   Department = "HR",        Salary = 45000 },
                new Employee { EmpID = 2, Name = "Sowmya",   Department = "IT",        Salary = 70000 },
                new Employee { EmpID = 3, Name = "Rohit",  Department = "IT",        Salary = 65000 },
                new Employee { EmpID = 4, Name = "Deeksha",   Department = "Finance",   Salary = 55000 },
                new Employee { EmpID = 5, Name = "Sreekanth",  Department = "IT",        Salary = 80000 }
            };

            // Ask user for department to filter
            Console.Write("Enter department to filter (e.g., IT, HR): ");
            string dept = Console.ReadLine();

            // LINQ query for filtering & sorting
            var result = employees
                         .Where(e => e.Department.Equals(dept, StringComparison.OrdinalIgnoreCase))
                         .OrderBy(e => e.Salary);

            // Display results
            Console.WriteLine($"\nEmployees in '{dept}' department sorted by salary:\n");

            foreach (var emp in result)
            {
                Console.WriteLine($"ID: {emp.EmpID}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            // If no results found
            if (!result.Any())
            {
                Console.WriteLine("No employees found in the specified department.");
            }
        }
    }
}
