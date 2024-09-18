using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS03
{
   
    internal class Test
    {
        private CardList list = new CardList();
        public void Menu()
        {
            CardList cardList = new CardList();
            CallMethod show;
            show = cardList.Show;
            int option;


            do
            {
                Console.WriteLine("---------- Menu ----------");
                Console.WriteLine("1. Add new PhoneCard");
                Console.WriteLine("2. Display all information");
                Console.WriteLine("3. Quit");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter your choice [1-3]: ");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            cardList.AddNew();
                            break;
                        }
                    case 2:
                        {
                            show();
                            break;
                        }
                    case 3:
                        {
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
                    Console.WriteLine("Progra3m exit....");
                    Environment.Exit(0);
                }
            } while (option != 3);

        }

        static void Main(string[] args)
        {
            new Test().Menu();
        }
    }
}
