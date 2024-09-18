using System.Security.Cryptography.X509Certificates;

namespace Tutorial_Database
{
    internal class App
    {
        private ManagerItems _manager;
        public App()
        {
            _manager = new ManagerItems();
        }

        public void menu()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("\t\tMenu");
                Console.WriteLine("\t1. View All Items");
                Console.WriteLine("\t2. Add New Item");
                Console.WriteLine("\t3. Delete a Item by Code");
                Console.WriteLine("\t4. Quit");

                Console.WriteLine("Your choice is: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _manager.select();
                        break;
                    case 2:
                        _manager.addNew();
                        break;
                    case 3:
                        _manager.deleteByCode();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
               
                Console.WriteLine("Are you want to continue");
                Console.WriteLine("\t1. Yes");
                Console.WriteLine("\t2. No");
                Console.WriteLine("Your choice is: ");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 2)
                {
                    Environment.Exit(0);
                }

            } while (choice != 4);
        }

        static void Main(string[] args)
        {
            new App().menu();
        }
    }
}
