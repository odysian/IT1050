using System;
class Program
{
  static void Main() {
    
    Console.WriteLine();
    Console.WriteLine("Test #1");
    Employee e1 = new Employee();
    e1.Intro();

    Console.WriteLine();
    Console.WriteLine("Test #2");
    Employee e2 = new Employee("John", "Smith", "1234", 45);
    e2.Intro();
    
  }
}
