using System;

class FactorialProgram
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int fact = 1;

        if (n < 0)
        {
            Console.WriteLine("Factorial is not possible for negative numbers.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial = " + fact);
        }
    }
}
