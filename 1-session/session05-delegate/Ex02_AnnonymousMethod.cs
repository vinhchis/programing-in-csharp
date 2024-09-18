using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    internal class Ex02_AnnonymousMethod
    {
        delegate void Display(string s);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string ch;
            Display display = delegate (string film) {
                Console.WriteLine($"-------{film}--------");
                Console.WriteLine("Displaying....");
                Console.WriteLine("--------The End--------");
            };
            do
            {
                display("Cuốn theo chiều gió");
                Console.WriteLine("Continue(Y/N): ");
                ch = Console.ReadLine().ToUpper();
                if (!ch.Equals("Y"))
                {
                    Console.WriteLine("Programing Exit....");
                    Environment.Exit(0);
                }
            }while(!ch.Equals("N"));
        }
    }
}
