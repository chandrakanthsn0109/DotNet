using System;

namespace SampleApp
{
    internal class Enum
    {
        enum Traine { Chandra, Lakshmi, Gowtham, Preethi, Priya };
        static void Main()
        {
            int Delivery = (int)Traine.Chandra;
            int BigBang = (int)Traine.Gowtham;

            Console.WriteLine($"Delivery Team: {Delivery}");
            Console.WriteLine($"BigBang Team: {BigBang}");
        }
    }
}
