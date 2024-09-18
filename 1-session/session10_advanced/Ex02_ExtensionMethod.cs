using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    static class Helper
    {
        static public string GetName(this Ex02_ExtensionMethod ex)
        {
            while (true)
            {
                Console.WriteLine("Enter your name:");
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("Name is required");
                    Console.WriteLine("Enter any key to continue....");
                    Console.ReadKey();
                }
                else
                {
                    ex.Name = s;
                    break;
                }
            }

            return ex.Name;
          
        }
    }
    internal class Ex02_ExtensionMethod
    {
        public string Name { get; set; }

        public void input()
        {
            Console.WriteLine("Enter your name:");
            string s = Console.ReadLine();
            Name = s;
        }


        static void Main(string[] args)
        {
            var ex = new Ex02_ExtensionMethod();
            ex.GetName();

            Console.WriteLine($"Name = {ex.Name}");
        }
    }
}
