using System;
class Program
{
  static void Main() {
    
    Console.WriteLine("Enter name of salesperson: ");
    string name = Console.ReadLine();
    
    Console.WriteLine("Enter sales amount: ");
    double salesAmount = Convert.ToDouble(Console.ReadLine());
    
    double commission = 200 + (0.09 * salesAmount);
    
    string performanceStatus;
    
    if (salesAmount >= 15000)
    {
        performanceStatus = "Outstanding";
    }
    else if (salesAmount >= 10000)
    {
        performanceStatus = "Excellent";
    }
    else if (salesAmount >= 5000)
    {
        performanceStatus = "Good";
    }
    else if (salesAmount >= 3000)
    {
        performanceStatus = "Average";
    }
    else 
    {
        performanceStatus = "Poor";    
    }
    
    Console.WriteLine("Name of Sales Person: " + name);
    Console.WriteLine("Total Sales Amount: $" + salesAmount);
    Console.WriteLine("Commission: $" + commission);
    Console.WriteLine("Performance Status: " + performanceStatus);
  }
}
