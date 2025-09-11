using System;

class Program
{
    static void Main() {
       Console.WriteLine("Inheritance");
       
       Console.WriteLine();
       Person p1 = new Person("111","Person1","F",Convert.ToDateTime("01/01/1976"));
       p1.Intro();
       
       Console.WriteLine();
       Student s1 = new Student("222","Student1","M",Convert.ToDateTime("01/01/1996"), "S1234", "Tri-C", 3.5);
       s1.Intro();
       
       Console.WriteLine();
       Faculty f1 = new Faculty("333", "Faculty1", "M", Convert.ToDateTime("04/17/1991"),
                                Convert.ToDateTime("01/01/2015"), "Tri-C");
       
       f1.GrantTenure();
       f1.Intro();
       
    }
}