using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Constructs
{
    internal class Ex01_Conversion
    {
        static void Main(string[] args)
        {
            int int_implicit = Int32.MaxValue;
            long long_implicit = int_implicit;
            long long_explicit = Int32.MinValue;
            int int_explicit = (int)long_explicit;

            Object boxing = int_implicit;
            int unBoxing = (int)boxing;
            Console.WriteLine($"Implicit (int -> long) :{int_implicit} => {long_implicit}");
            Console.WriteLine($"Explicit (long -> int): {long_explicit} => {int_explicit}");
            Console.WriteLine($"Boxing(boxing): {boxing}");
            Console.WriteLine($"unBoxing(unboxing): {unBoxing}");

            Console.ReadKey();
        }
    }
}
