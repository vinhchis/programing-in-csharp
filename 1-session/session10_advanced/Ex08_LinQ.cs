using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal class Ex08_LinQ
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Peter", "Sam",
"Philip","Andy","Philip","Mary", "John","Pamela"};
            var query = from string name in arr
                        select name;
            Console.WriteLine("Names retrieved using sequential LINQ");
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
            var plinqQuery = from string name in arr.AsParallel()
                             select name;
            Console.WriteLine("Names retrieved using PLINQ");
            foreach (var n in plinqQuery)
            {
                Console.WriteLine(n);
            }
        }
    }
}
