using System;

class Faculty : Person
{

    public string Id { get; set; } = "Unknown";
    // IDE was throwing warnings about null values so I learned how 
    // to set them at declaration to make them go away
    public string Title { get; set; }
    public DateTime DateOfEmployment{get; set;}
    public string Employer { get; set; } = "Unknown"; 
    public decimal YearlySalary{get; set;}
    public bool Tenured{get; set;}

    // no parameter constructor
    public Faculty() : base() 
    {
        Title = "Instructor";
    }
    
    // 2 parameter constructor that concats first+lastnames into Name
    public Faculty(string firstName, string lastName) : base() 
    {
        Name = firstName + " " + lastName;
        Title = "Instructor";
    }
    
    // constructor to set most values important to methods
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

    public bool Promote()
    {
        if (Title == "Instructor" && (DateTime.Today.Year - DateOfEmployment.Year) >= 2)
        {
            Title = "Assistant Professor";
            Console.WriteLine("Faculty promoted to Assistant Professor rank");
            return true;
        }
        else if (Title == "Assistant Professor" && (DateTime.Today.Year - DateOfEmployment.Year) >= 5)
        {
            Title = "Associate Professor";
            Console.WriteLine("Faculty promoted to Associate Professor rank");
            return true;
        }
        else if (Title == "Associate Professor" && (DateTime.Today.Year - DateOfEmployment.Year) >= 10)
        {
            Title = "Professor";
            Console.WriteLine("Faculty promoted to Professor rank");
            return true;
        }
        else if (Title == "Professor")
        {
            Console.WriteLine("No more promotion possible");
            return false;
        }
        else
        {
            Console.WriteLine("Not enough experience");
            return false;
        }
        
    }
    public override void Intro()
    {
        base.Intro();

        if (Tenured)
        {
            Console.WriteLine("I work as a " + Title + " at " + Employer + " since " +
                              DateOfEmployment.Year + " and I am tenured");
        }
        else
        {
            Console.WriteLine("I work as a " + Title + " at " + Employer + " since " +
                              DateOfEmployment.Year + " and I am not tenured");
        }
    }
}
