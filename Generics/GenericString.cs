using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericString
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Chandra");
            list.Add("Lakshmi");
            list.Add("Preethi");
            list.Add("Gowtham");
            list.Add("Priya");

            foreach (string i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
