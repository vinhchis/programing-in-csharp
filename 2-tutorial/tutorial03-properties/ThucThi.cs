using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial03_Properties
{
    abstract class CHA
    {
        public abstract string Code { get; set; }
        public abstract string Name { get; set; }
        public abstract void input();
    }
    class DoiTuong: CHA
    {
        private string code, name;

        public override string Code { get { return code; } set { code = value; } }
        public override string Name { get { return name; } set { name = value; } }


        // Defailt Constructor
        public override void input()
        {
            Console.WriteLine("Enter code:");
            Code = Console.ReadLine();
            Console.WriteLine("Enter name:");
            Name = Console.ReadLine();

        }

        // Output
        public override string ToString()
        {

            return $"Code: {Code} - Name: {Name}";
        }
    }

    class QuanLy
    {
        int max, next;
        //static int max = 2;
        //DoiTuong[] doituong = new DoiTuong[max];
        DoiTuong[] doituong;
        public QuanLy()
        {
            max = 2;
            next = 0;
            doituong = new DoiTuong[max];
        }
        public void addNew()
        {
            doituong[next] = new DoiTuong();
            doituong[next].input();
            next++;
        }
        public void display()
        {
            if (next > 0)
            {
                for (int i = 0; i < next; i++)
                {
                    Console.WriteLine(doituong[i]);
                }
            }
            else
            {
                Console.WriteLine("Nothing to display");
            }
        }
    }


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
                    case 2:
                        {
                            quanly.display();
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
                    Console.WriteLine("Program exit....");
                    Environment.Exit(0);
                }
            } while (option != 3);

        }
        static void Main(string[] args)
        {
            new ThucThi().menu();
        }
    }
}
