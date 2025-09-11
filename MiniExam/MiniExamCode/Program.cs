using System;
class Program
{
  static void Main() {
    
    for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter height (inches): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter weight (lbs): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = (703 * weight) / (height * height);

            Console.WriteLine($"{name}'s bmi is: {bmi}");

            if (bmi >= 30.0)
            {
                Console.WriteLine("Health Status: Obese");
            }
            else if (bmi >= 25.0)
            {
                Console.WriteLine("Health Status: Overweight");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Health Status: Healthy Weight");
            }
            else
            {
                Console.WriteLine("Health Status: Underweight");
            }
        }
  }
}
