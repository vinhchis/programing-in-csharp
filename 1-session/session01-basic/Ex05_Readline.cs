using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Ex05_Readline
    {
        static void Main(string[] args)
        {
            int min, max, avg;
            int test = Int16.MaxValue;
            Console.WriteLine("Enter mininum Temperature: ");
            //min = Int32.Parse(Console.ReadLine());
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum Temperature: ");
            //max = Int32.Parse(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Average: {(min+max)/2} Celcius");
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
