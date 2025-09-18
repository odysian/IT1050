// Create a C# app to calculate Cylinder Volume utilizing the concept of functions
// Create a function called CylinderVolume
// Input: radius (double) and height (double)
// Declare a variable called cylVolume of type double
// Logic: Use the following statement to calculate the volume:
// cylVolume = 3.14 * radius * radius * height
// Return cylVolume. 
// In the main method, do the following
// a. Declare variables radius and height as double. Declare variable volume as double.
// b. Prompt the user for the radius and height of a cylinder and store in variables
// c. To calculate the cylinder volume, call the method CylinderVolume with input as radius and height 
// d. Store the return value from CylinderVolume to a variable called volume
// e. Display the volume of the cylinder.
// Save the jdoodle project. Get a shareable link and submit to this mini e

using System;
class Program
{
  static double CylinderVolume(double radius, double height)
  {
    double cylVolume = 3.14 * radius * radius * height;
    return cylVolume;
  }

  static void Main()
  {
    double radius;  
    double height;
    double volume;

    Console.WriteLine("Enter Radius: ");
    radius = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter Height: ");
    height = Convert.ToDouble(Console.ReadLine());

    volume = CylinderVolume(radius, height);
    Console.WriteLine($"Cylinder volume is {volume}");
  }
}

