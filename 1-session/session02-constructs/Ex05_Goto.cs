﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Constructs
{
    internal class Ex05_Goto
    {
        void menu()
        {
            int option;
        more:
            Console.WriteLine("=======================================");
                Console.WriteLine("\t1. Add new");
                Console.WriteLine("\t2. Display");
                Console.WriteLine("\t3. Exit");
                Console.WriteLine("=======================================");
                Console.WriteLine("Enter your choice [1-3]: ");
                option = Convert.ToInt16(Console.ReadLine());
            
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Add new");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Display");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Program exit");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Your choice is incorrect");
                            break;
                        }

                }
                Console.WriteLine("Continue?: Y/N");
                string ch = Console.ReadLine().ToUpper();
                if (ch.Equals("Y"))
                {
                    goto more;
                }


            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            new Ex05_Goto().menu();
        }
    }


}