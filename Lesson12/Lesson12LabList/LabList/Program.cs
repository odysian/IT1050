using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Employee e1 = new Employee(101, "Alice", "Johnson", "Developer");
        Employee e2 = new Employee(102, "Bob", "Smith", "HR Rep");
        Employee e3 = new Employee(103, "Charlie", "Brown", "Analyst");
        Employee e4 = new Employee(104, "Diana", "Prince", "Marketing");
        Employee e5 = new Employee(105, "Evan", "Davis", "Engineer");
        Employee e6 = new Employee(106, "Fiona", "Green", "Sales Rep");

        EmployeeManager em1 = new EmployeeManager(901, "Abraham", "Lincoln", "Manager");
        EmployeeManager em2 = new EmployeeManager(902, "George", "Washington", "Team Lead");


        // Test 1 - Employee Manager 1
        em1.AddEmployee(e1);
        em1.AddEmployee(e2);
        em1.AddEmployee(e3);
        em1.DisplayEmployees();
        em1.UpdateEmployee(102, "HR Rep2");
        em1.RemoveEmployee(101);
        em1.DisplayEmployees();
        Console.WriteLine("END TEST 1");
        Console.WriteLine();
        
        // Test 2 Employee Manager 2
        em2.AddEmployee(e4);
        em2.AddEmployee(e5);
        em2.AddEmployee(e6);
        em2.DisplayEmployees();
        em2.UpdateEmployee(105, "HR Rep2");
        em2.RemoveEmployee(106);
        em2.DisplayEmployees();
        Console.WriteLine("END TEST 2");

    }
}