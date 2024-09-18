using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_Final
{
    internal class BooktTest
    {
        private BookManage manage;
        public void Menu()
        {
            manage = new BookManage();
            int option;

            do
            {
                Console.WriteLine("---------- Menu ----------");
                Console.WriteLine("1. Create New");
                Console.WriteLine("2. Find by isSale");
                Console.WriteLine("3. Find All");
                Console.WriteLine("4. Exit");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter your choice [1-4]: ");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            manage.createBook();
                            break;
                        }
                    case 2:
                        {
                            manage.FinByIsSale(true);
                            break;
                        }
                    case 3:
                        {
                            manage.FindAll();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Program exit....");
                            Environment.Exit(0);
                            break;
                        }
                }

                Console.WriteLine("Continue Y/N:");
                string ch;
                ch = Console.ReadLine().ToUpper();
                if (!ch.Equals("Y"))
                {
                    Console.WriteLine("Progra3m exit....");
                    Environment.Exit(0);
                }
              
                
            } while (option != 4);

        }
        static void Main(string[] args)
        {
            new BooktTest().Menu();
        }
    }
}
