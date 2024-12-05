using System;

namespace SampleApp
{
    internal class MultiArray
    {
        static void Main()
        {
            //Multidimensional Array
            string[,] bikes = { { "Yamaha", "RX", "100" }, { "Pulsar", "NS", "200" }, { "Hero", "Splender", "135" } };
            for (int i = 0; i < bikes.GetLength(0); i++)
            {
                if (bikes[i, 2].CompareTo("125") > 0)
                {
                    Console.WriteLine("BIKE" + i + ":");

                    for (int j = 0; j < bikes.GetLength(1); j++)
                    {
                        Console.WriteLine($"{bikes[i, j]} ");
                    }
                }
            }
        }
    }
}
