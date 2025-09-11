using System;
using System.Collections.Generic;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Hotdog");
            food.Add("Hamburger");
            food.Add("fries");

            food.Remove("fries");
            food.Insert(0, "sushi");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("Hotdog"));


            foreach (string item in food)
            {
                Console.WriteLine(item);
            }


        }
    }
}