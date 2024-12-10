using System;

namespace Generics
{
    internal class RefOut
    {
        //static void Main(string[] args)
        //{
        //    int add = 0;
        //    int sub = 0;
        //    int mul = 0;
        //    int div = 0;
        //    int add1;
        //    int sub1;
        //    int mul1;
        //    int div1;

        //    Math(90, 3, ref add, ref sub, ref mul, ref div);
        //    Console.WriteLine($"Addition : {add}");
        //    Console.WriteLine($"Subtraction : {sub}");
        //    Console.WriteLine($"Multiplication : {mul}");
        //    Console.WriteLine($"Division : {div}");

        //    Math1(7, 3, out add1, out sub1, out mul1, out div1);
        //    Console.WriteLine($"Addition : {add1}");
        //    Console.WriteLine($"Subtraction : {sub1}");
        //    Console.WriteLine($"Multiplication : {mul1}");
        //    Console.WriteLine($"Division : {div1}");
        //}

        //public static void Math(int num1, int num2, ref int addition, ref int subtraction, ref int multiplication, ref int division)
        //{
        //    addition = num1 + num2;
        //    subtraction = num1 - num2;
        //    multiplication = num1 * num2;
        //    division = num1 / num2;
        //}

        //public static void Math1(int num1, int num2, out int addition1, out int subtraction1, out int multiplication1, out int division1)
        //{
        //    addition1 = num1 + num2;
        //    subtraction1 = num1 - num2;
        //    multiplication1 = num1 * num2;
        //    division1 = num1 / num2;
        //}
        static void Main(string[] args)
        {
        

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {

                Console.WriteLine("You are eligible to vote!");
            }

        ineligible:
            Console.WriteLine("You are not eligible to vote!");
        }
    }
}
