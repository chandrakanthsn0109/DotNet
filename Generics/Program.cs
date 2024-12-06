using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //GenericClass<string> gs = new GenericClass<string>("Welcome");
            //GenericClass<int> gi = new GenericClass<int>(7);
            //GenericClass<double> gd = new GenericClass<double>(234567.2567);

            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add("Chandra");

            //foreach (var i in array)
            //{
            //    Console.WriteLine(i);
            //}

            Linq l = new Linq();
            l.Aggregate();
            l.AnyAll();
            l.Averge();
            l.Casting();
            l.Take();
            l.LinQuerr();
        }
    }
}
