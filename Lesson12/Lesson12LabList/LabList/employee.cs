using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

public class Employee
{
    
    public int Id {get; set;} = 999;
    public string Firstname {get; set;} = "Unknown";
    public string Lastname {get; set;} = "Unknown";
    public string Address {get; set;} = "Unknown";
    public string Title {get; set;} = "Unknown";
    public DateTime JoiningDate {get; set;}
    public bool IsActive{ get; set;}
    
    public Employee()
    {
        IsActive = true;
    }
    
    public Employee(int id, string fname, string lname, string title)
    {
        Id = id;
        Firstname = fname;
        Lastname = lname;
        Title = title;
        IsActive = true;
    }
    
    public void Intro()
    {
        Console.WriteLine("Employee first name: {0} last name: {1} title: {2} currentStatus : {3}", Firstname, Lastname, Title, IsActive);
    }
}