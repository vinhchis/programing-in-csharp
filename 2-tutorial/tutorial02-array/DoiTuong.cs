using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2_Array
{
    internal class DoiTuong
    {
        String name, code;

        // Defailt Constructor
        public DoiTuong()
        {
            Console.WriteLine("Enter code:");
            code = Console.ReadLine();
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
        }

        // Output
        public override string ToString()
        {
            
            return $"Code: {code} - Name: {name}";
        }
    }
}
