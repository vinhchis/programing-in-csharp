using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    delegate int ProcessNumber(int input);
    internal class Ex07_Lambda
    {
       
        static void Main(string[] args)
        {
            ProcessNumber del = input => input * input;
            Console.WriteLine(del(5));
        }
       
    }

   
}
