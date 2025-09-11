using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inheritance");
        Console.WriteLine();
        //    Console.WriteLine();
        //    Person p1 = new Person("111","Person1","F",Convert.ToDateTime("01/01/1976"));
        //    p1.Intro();

        //    Console.WriteLine();
        //    Student s1 = new Student("222","Student1","M",Convert.ToDateTime("01/01/1996"), "S1234", "Tri-C", 3.5);
        //    s1.Intro();
        
        // 2 parameter constructor test
        // Console.WriteLine("Test 4 - New Faculty Test"); 
        // Faculty f4 = new Faculty("Tom", "Hardy");
        // f4.Intro();


        // Test Case 1
        // Add faculty member and check for promotion and tenure
        // Less than 2yrs exp so no promotion or tenure

        Console.WriteLine("Test 1 - New Faculty Test");
        Faculty f1 = new Faculty("111", "John Smith", "M", Convert.ToDateTime("01/01/1980"),
                                Convert.ToDateTime("01/01/2024"), "Tri-C");
        f1.Intro();
        Console.WriteLine();
        Console.WriteLine("Checking promotion:");
        f1.Promote();
        Console.WriteLine("Checking tenure:");
        f1.GrantTenure();
        Console.WriteLine();
        f1.Intro();


        // Test Case 2
        // More than 2yrs exp so promotion but no tenure
        
        Console.WriteLine();
        Console.WriteLine("Test 2 - Promotion Test");
        Faculty f2 = new Faculty("222", "Clark Kent", "M", Convert.ToDateTime("01/01/1980"),
                                Convert.ToDateTime("01/01/2022"), "Metropolis U");
        Console.WriteLine();
        Console.WriteLine("Checking promotion:");
        f2.Promote();
        Console.WriteLine("Checking tenure:");
        f2.GrantTenure();
        Console.WriteLine();
        f2.Intro();

        // Test Case 3
        // Manually set rank to professor and check tenure
        
        Console.WriteLine();
        Console.WriteLine("Test 3 - Max rank + tenure test");
        Faculty f3 = new Faculty("333", "Jane Doe", "F", Convert.ToDateTime("01/01/1980"),
                                Convert.ToDateTime("01/01/2010"), "Tri-C");
        Console.WriteLine();
        f3.Title = "Professor";
        Console.WriteLine("Checking promotion:");
        f3.Promote();
        Console.WriteLine("Checking tenure:");
        f3.GrantTenure();
        Console.WriteLine();
        f3.Intro();
    }
}