using System;
class Program
{
  static void Main() {
      
    double totalSpeed = 0;
    
    Console.WriteLine("How many cars?: ");
    int numCar = Convert.ToInt32(Console.ReadLine());
    
    for (int i=1; i<=numCar; i++)
    {
        Console.WriteLine("How far did the car drive? (miles): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("How long did the car drive for? (hours): ");
        int time = Convert.ToInt32(Console.ReadLine());
        
        double speed = distance / time;
        totalSpeed = totalSpeed + speed;
        Console.WriteLine("Car #"+ i +" averaged "+ speed +" mph");
    }
    
    double averageSpeed = totalSpeed / numCar;
    Console.WriteLine("The average speed of all the cars is " + averageSpeed + " mph");
    
  }
}