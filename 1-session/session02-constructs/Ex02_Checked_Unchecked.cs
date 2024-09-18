using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Constructs
{
    internal class Ex02_Checked_Unchecked
    {
        void exSimple() { 
            int val = int.MaxValue;
            val += 4;
            Console.WriteLine(val);
        }
        void exChecked()
        {
            checked
            {
                int val = int.MaxValue;
                val += 2;
                Console.WriteLine(val);
            }
        }
        void exUnChecked() {
            unchecked {
                int val = int.MaxValue;
                val += 2;
                Console.WriteLine(val);
            }
        }
        static void Main(string[] args)
        {
            var ex02 = new Ex02_Checked_Unchecked();
            ex02.exSimple();
            //ex02.exChecked();
            //ex02.exUnChecked();
            Console.ReadKey();
        }
    }
}
