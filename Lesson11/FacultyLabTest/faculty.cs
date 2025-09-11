using System;

class Faculty : Person
{
    
    public string Id{get; set;}
    public string Title{get; set;}
    public DateTime DateOfEmployment{get; set;}
    public string Employer{get; set;}
    public decimal YearlySalary{get; set;}
    public bool Tenured{get; set;}
    
    public Faculty() : base()
    {
        Title = "Instructor";
    }
    public Faculty(string ssn, string name, string gender, DateTime dob, DateTime doe, string employer) 
    : base(ssn, name, gender, dob)
    {
        Title = "Instructor";
        DateOfEmployment = doe;
        Employer = employer;
        
    }
    public bool GrantTenure()
    {
        if ((DateTime.Today.Year - DateOfEmployment.Year) >= 5)
        {
            Tenured = true;
        }
        else 
        {
            Tenured = false;
        }
        return Tenured;
    }
    
    public override void Intro()
    {
        base.Intro();
        Console.WriteLine("I am an " + Title);
        
        if (Tenured)
        {
           Console.WriteLine("I work as an " + Title + " at " + Employer + " since " +
                             DateOfEmployment.Year + " and I am tenured"); 
        }
        else
        {
            Console.WriteLine("I work as an " + Title + " at " + Employer + " since " +
                              DateOfEmployment.Year);
        }
    }
}
