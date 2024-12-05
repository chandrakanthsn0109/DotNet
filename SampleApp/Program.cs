using System;
using System.Collections.Generic;
using System.Linq;//Language Integrated Query
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportBikes sb = new SportBikes();
            sb.Company();
            sb.Capacity();
            sb.Milege();

            FamilyBikes f = new FamilyBikes();
            f.Company();
            f.Capacity();
            f.Milege();
            f.Add(10, 7, 6);
            f.Add(7, 3);

        }
    }
}
