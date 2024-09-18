using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Properties
{
    internal class Ex03_Indexer
    {
        private int[] initPassword = new int[10];

        // Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 9)
                {
                    return 0;
                }
                return initPassword[index];
            }
            set { initPassword[index] = value; }
        }

        static void Main(string[] args)
        {
            var admin = new Ex03_Indexer();
            // Set Password
            for(int i = 0; i < 10; i++)
            {
                //admin.initPassword[i] = 123;
                admin[i] = 123;
            }
            // Report password list
            for(int i = 0; i < 10; i++)
            {
                //Console.WriteLine($"Student {i+1} - password: {admin.initPassword[i]}");
                Console.WriteLine($"Student {i + 1} - password: {admin[i]}");
            }

            Console.ReadKey();
        }
    }
}
