using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double avg = (num1 + num2) / 2;
        Console.WriteLine($"Average of numbers: {avg}");
    }
}
