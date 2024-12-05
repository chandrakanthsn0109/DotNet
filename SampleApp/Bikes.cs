using System;

namespace SampleApp
{
    class SportBikes : Type
    {
        public override void Capacity()
        {
            //Console.WriteLine("Enter the Capacity");
            //int cc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Capacity: 1000cc");
        }

        public override void Company()
        {
            //Console.WriteLine("Enter the Company");
            //string com = Console.ReadLine();
            Console.WriteLine("Company: BMW");
        }

        public override void Milege()
        {
            //Console.WriteLine("Enter the Milege");
            //int ml = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Milege: 16km");
        }

    }

    class FamilyBikes : Type
    {
        public override void Capacity()
        {
            //Console.WriteLine("Enter the Capacity");
            //int cc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Capacity: 135cc");
        }

        public override void Company()
        {
            //Console.WriteLine("Enter the Company");
            //string com = Console.ReadLine();
            Console.WriteLine("Company: HeroHonda");
        }

        public override void Milege()
        {
            //Console.WriteLine("Enter the Milege");
            //int ml = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Milege: 65km");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void Add(int a, int b , int c) {  
            Console.WriteLine(a+b+c);
        }
    }
}
