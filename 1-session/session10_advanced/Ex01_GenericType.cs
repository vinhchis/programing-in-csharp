using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal class Ex01_GenericType
    {
        delegate T GenericType<T>(T type);

        static void Main(string[] args)
        {
            GenericType<string> printString;

            printString = delegate (string s)
            {
                Console.WriteLine($"GenericType<String>: {s}");
                return s;
            };

            printString("Hello");

            GenericType<int> printInt;

            printInt = delegate (int i)
            {
                Console.WriteLine($"GenericType<int>: {i} /100 Marks");

                return i;
            };

            printInt(100);


        }
    }
}
