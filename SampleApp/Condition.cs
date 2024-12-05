using System;

namespace SampleApp
{
    internal class Condition
    {
        static void Main()
        {
            string name;
            Console.WriteLine("Enter the Name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Welcome to C#");
            Console.WriteLine("Enter your Nationality: ");
            string nationality = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name: ");
            string name1 = Console.ReadLine();
            if (age >= 18 && nationality == "Indian")
            {
                //With using String Interpolation
                Console.WriteLine($"{name1} eligible to vote");
            }
            else
            {
                //Without using String Interpolation
                Console.WriteLine(name1 + " not eligible to vote");
            }
            Console.ReadKey();
        }
    }
}
