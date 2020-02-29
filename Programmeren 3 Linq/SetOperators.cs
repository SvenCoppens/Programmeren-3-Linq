using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Programmeren_3_Linq
{
    class SetOperators
    {
        static IList<string> strList1 = new List<string>() { "one", "two", "three", "four", "five" };
        static IList<string> strList2 = new List<String>() { "four", "five", "six", "seven", "eigth" };
        
        public static void Intersect()
        {
            var result = strList1.Intersect(strList2);
            Console.WriteLine("intersect-----------------------");
            foreach(string str in result)
                Console.WriteLine(str);
        }
        public static void Union()
        {
            var result = strList1.Union(strList2);
            Console.WriteLine("Union-----------------------");
            foreach (string str in result)
                Console.WriteLine(str);
        }

        public static void Except()
        {
            var result = strList1.Except(strList2);
            Console.WriteLine("except-----------------------");
            foreach (string str in result)
                Console.WriteLine(str);
        }

    }
}
