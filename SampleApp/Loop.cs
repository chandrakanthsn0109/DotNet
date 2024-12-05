using System;

namespace SampleApp
{
    internal class Loop
    {
        static void Main()
        {
            // 1,2,4,5,6,7,8,10
            for (int a = 1; a <= 10; a++)
            {
                if (a == 3 || a == 9)
                {
                    continue;
                }
                Console.WriteLine(a);
            }

            //1, 4, 3, 4, 25, 6
            for (int a = 1; a <= 6; a++)
            {
                if (a == 2 || a == 5)
                {
                    //Console.Write(a * a + ",");
                    Console.Write(Math.Pow(a, 2) + ",");
                    continue;
                }
                Console.Write(a);
                if (a == 6)
                {
                    break;
                }
                Console.Write(",");

            }
            Console.ReadKey();
        }
    }
}
