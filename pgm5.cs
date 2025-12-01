using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("input.txt");
        Console.WriteLine("File Content:\n" + text);

        File.WriteAllText("output.json", JsonSerializer.Serialize(text));
        Console.WriteLine("Saved to JSON file.");
    }
}
