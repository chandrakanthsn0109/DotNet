using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Integer
    {
        static void Main()
        {
            //Adding elements to list
            List<int> al = new List<int>();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(6);
            al.Add(10);
            al.Add(5);
            al.Add(7);
            al.Add(18);

            //Displaying elements
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }

            //Checking Wheather element has or not
            bool a = al.Contains(7);
            Console.WriteLine(a);


            //Removing the element
            al.Remove(4);

            //Displaying elements after 
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Finding Average
            double avg = al.Average();
            Console.WriteLine(avg);

            //Searching the element
            int search = al.BinarySearch(7);
            Console.WriteLine(search) ;

            //Counting how many elements
            int count = al.Count();
            Console.WriteLine(count);

            //Displaying after removing element based on the index
            al.RemoveAt(4);
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //finding maximum element in the list
            int max = al.Max(x => x);
            Console.WriteLine(max);

            //Reversing the list
            al.Reverse();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Sorting in ascending order
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            //Sorting in descending order
            int sum = al.Sum();
            Console.WriteLine(sum);

        }
    }
}
