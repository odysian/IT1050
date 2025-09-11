using System;
#nullable disable

public class Person{
    
 public string FirstName{get;set;}
 public string LastName{get;set;}
 public string Email{get;set;}
 public string Gender{get;set;}
 public DateTime DateOfBirth{get;set;}
 
 //Constructor
 public Person(){
     FirstName="Unknown";
     LastName="Unknown";
     Email="Unknown";
     Gender="X";
 }
 
 //Constructor w/parameters
 public Person(string firstName, string lastName, string email){
     FirstName=firstName;
     LastName=lastName;
     Email=email;
     Gender="X";
 }
    
 public virtual void Intro(){ //Step #3
     Console.WriteLine($"Hello I am a person named {FirstName} {LastName}");
     Console.WriteLine("Gender: "+Gender);
     Console.WriteLine("Email: "+Email);
 }    
}