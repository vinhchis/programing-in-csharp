using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal class Ex04_PartialType_AB : PartialType<string>
    {
        public Ex04_PartialType_AB(string code, string name) : base(code, name) { }

        static void AddNew(out string code, out string name)
        {
            Console.WriteLine("Enter code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();


        }

        public void Display()
        {
            Console.WriteLine($"Information: {this}");
        }


        static void Main(string[] args)
        {
            string code, name;

            AddNew(out code, out name);

            new Ex04_PartialType_AB(code, name).Display();

        }
    }
}
