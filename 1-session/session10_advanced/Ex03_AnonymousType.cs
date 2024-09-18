using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal class Ex03_AnonymousType
    {
        static void Main(string[] args)
        {
            // Object Initializer
            var item = new
            {
                Code = "RHHSH-12",
                Name = "nanajaj",
                Price = 1000
            };

            Console.WriteLine($"Code = {item.Code}, Name = {item.Name}, Price = {item.Price}");
        }
        


        
    }
}
