using System;
class Employee {
    
    private string firstName;
    private string lastName;
    private string id;
    private int age;
    private double yearlySalary;
    private string employmentStatus;
    
    public Employee()
    {
        firstName = "Unknown";
        lastName = "Unknown";
        id = "Unknown";
        age = 0;
        employmentStatus = "Active";
        Console.WriteLine("A new employee object has been created");
    }
    
    public Employee(string e_fname, string e_lname, string e_id, int e_age)
    {
        firstName = e_fname;
        lastName = e_lname;
        id = e_id;
        age = e_age;
        employmentStatus = "Active";
        
    }
    
    public void Intro()
    {
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("id: " + id);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Employment Status: " + employmentStatus);
    }
}