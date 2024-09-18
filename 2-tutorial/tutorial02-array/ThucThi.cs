using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2_Array
{
    internal class ThucThi
    {
        void menu()
        {
            int option;
            var quanly = new QuanLy();

            do
            {
                Console.WriteLine("---------- Menu ----------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Exit");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter your choice [1-3]: ");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            quanly.addNew();
                            break;
                        }
                    case 2: {
                            quanly.display();
                            break;
                        }
                    case 3: {
                            Console.WriteLine("Program exit....");
                            Environment.Exit(0);
                            break;
                        }
                }

                Console.WriteLine("Continue Y/N:");
                String ch;
                ch = Console.ReadLine().ToUpper();
                if (!ch.Equals("Y"))
                {
                    Console.WriteLine("Program exit....");
                    Environment.Exit(0);
                }
            } while (option != 3);

        }
        static void Main(string[] args)
        {
            var tt = new ThucThi();
            tt.menu();
        }
    }
}
