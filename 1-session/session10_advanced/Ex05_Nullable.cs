using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal class Ex05_Nullable
    {
        static void Main(string[] args)
        {
            int empId = 10;
            string empName = "Patrick";
            char? role = null;
            int price;

            // Null Coalescing
            //int? Input = null;
            int? Input = 10000;

            price = Input ?? -1;

            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            if (role.HasValue == true)
            {
                Console.WriteLine("Role: " + role.Value);
            }
            else
            {
                Console.WriteLine("Role: null");
            }

            Console.WriteLine("Employee Price: " + price);


         
        }
    }
        
}
