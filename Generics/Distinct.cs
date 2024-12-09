using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Bike
    {
        public int id { set; get; }
        public string name { set; get; }
        public int? cc { set; get; }
    }
    internal class Distinct
    {
       
        static void Main()
        {
            List<int> li = new List<int>() {1, 2, 3, 2, 4, 2, 5, 6, 3, 7, 21, 6, 9, 10, 12, 4};

            //Using Method Syntax
            var num = li.Distinct();
            foreach (var item in num)
            {
                Console.WriteLine(item.ToString());
            }

            //Using Query Syntax
            Console.WriteLine("----------------------------");
            int i = 0, count = 0;
            var qs = (from item in li where item%2!=0 select item).Distinct();
            foreach (var item in qs)
            {
                i = i + item;
                count++;
                Console.WriteLine(item);
            }
            double avg = i/count;
            Console.WriteLine("Average:" + avg);

            //To Avoid too many steps to calculate average 
            List<int> qs1 = (List<int>)(from item in li where item % 2 != 0 select item).Distinct().ToList();
            double avg2 = qs1.Average();
            Console.WriteLine("Average:" + avg2);

            qs1.Sort();
            foreach (var item in qs1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------------");

            List<Bike> bikeList = new List<Bike>()
            {
                new Bike(){id = 1, name = "RX", cc = 135},
                new Bike(){id = 2, name = "RX", cc = 100},
                new Bike(){id = 3, name = "NS", cc = 200},
                new Bike(){id = 4, name = "RE", cc = 350},
                new Bike(){id = 5, name = "Duke", cc = 250}
            };

            List<Bike> bikes = bikeList.OrderBy(x => x.name).ThenBy(x => x.cc).ToList();
            foreach (Bike bike in bikes)
            {
                Console.WriteLine("Bike Id:" + bike.id + "  Bike Name:" + bike.name + "  Bike CC:" + bike.cc);
            }

            Console.WriteLine("------------------------------------------------------------------");
            List<Bike> bikeDes = bikeList.OrderBy(x => x.name).ThenByDescending(x => x.cc).ToList();
            foreach (Bike bike in bikeDes)
            {
                Console.WriteLine("Bike Id:" + bike.id + "  Bike Name:" + bike.name + "  Bike CC:" + bike.cc);
            }

        }
    }
}
