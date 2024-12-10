using System;

namespace Generics
{
    internal class Delegate
    {
        delegate string DelegateMerger(string s1, string s2);//declaring delegate   
        public class DelegateExample
        {
            static string MergedString = string.Empty;
            public static string FullName(string fn, string ln)
            {
                MergedString = $"{fn} {ln}";
                return MergedString;
            }
            public static string FullLocation(string state, string place)
            {
                MergedString = $"{place} is a city in {state} state";
                return MergedString;
            }
            public static string getFullString()
            {
                return MergedString;
            }

            static void Main(string[] args)
            {
                DelegateMerger mer1 = new DelegateMerger(FullName);
                DelegateMerger mer2 = new DelegateMerger(FullLocation);

                mer1("Chandrakanth S N", "CSN");
                Console.WriteLine("After mer1 delegate, The String is:" + getFullString());

                mer2("Karnataka", "Mysore");
                Console.WriteLine("After mer2 delegate, The String is:" + getFullString());
            }
        }
    }
}
