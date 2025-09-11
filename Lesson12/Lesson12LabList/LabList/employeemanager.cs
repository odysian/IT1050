using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

public class EmployeeManager
{

    public int Id { get; set; } = 000;
    public string Firstname { get; set; } = "Unknown";
    public string Lastname { get; set; } = "Unknown";
    public string Title { get; set; } = "Unknown";
    public List<Employee> DirectReportList = new List<Employee>();

    public EmployeeManager() { }

    public EmployeeManager(int id, string firstname, string lastname, string title)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
        Title = title;
    }

    public void AddEmployee(Employee employee)
    {
        DirectReportList.Add(employee);
        Console.WriteLine(employee.Firstname + " " +  employee.Lastname +
                          " added to direct report list of manager Id: " + Id);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine();
        Console.WriteLine("Employee List: ");
        if (DirectReportList.Count == 0)
        {
            Console.WriteLine("No employees found");
        }
        else
        {
            foreach (Employee employee in DirectReportList)
            {
                Console.WriteLine();
                Console.WriteLine("Id: " + employee.Id);
                Console.WriteLine("First Name: " + employee.Firstname);
                Console.WriteLine("Last Name: " + employee.Lastname);
                Console.WriteLine("Title: " + employee.Title);
            }
        }
    }

    public Employee SearchEmployee(int id)
    {
        // your solution from the video was much simpler than my
        // initial solution which i commented out below
        return DirectReportList.Find(e => e.Id == id);
        
        // foreach (Employee employee in DirectReportList)
        // {
        //     if (employee.Id == id)
        //     {
        //         return employee;
        //     }
        // }
        // return null;
    }
    
    public bool UpdateEmployee(int id, string newTitle)
    {
        Console.WriteLine();
        Employee foundEmployee = SearchEmployee(id);

        if (foundEmployee != null)
        {
            foundEmployee.Title = newTitle;
            Console.WriteLine("Employee " + id + " title updated to " + newTitle);
            return true;
        }
        else
        {
            Console.WriteLine("Cannot update title");
            return false;
        }
    }

    public bool RemoveEmployee(int id)
    {
        Console.WriteLine();
        Employee foundEmployee = SearchEmployee(id);

        if (foundEmployee != null)
        {
            DirectReportList.Remove(foundEmployee);
            Console.WriteLine("Removed employee " + id + " from direct report list");
            return true;
        }
        else
            Console.WriteLine("Cannot Remove: Employee Id: " + id + " not found");
            return false;
    }
}