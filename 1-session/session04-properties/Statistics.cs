using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Properties
{
   
    internal class Statistics
    {
        public int count { get; set; }
        public int sum { get; set; }

        public Statistics()
        {
            count = 0;
            sum = 0;
        }

        public void AddNumber(int number)
        {       
            sum += number;
            count++;
        }
        static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);

            Console.ReadKey();
        }
        
        
    }
}
