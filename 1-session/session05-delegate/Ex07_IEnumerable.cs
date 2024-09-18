using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Session05_Delegate
{
    internal class Ex07_IEnumerable: IEnumerable
    {
        int[] num = {1,2,3,4,5,6,7,8,9,10 };

        public IEnumerator GetEnumerator()
        {
            return num.GetEnumerator();
        }

        public void display()
        {
            Console.WriteLine("Đọc mảng từ class: ");
            foreach(int i in this) Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            
               
            Console.OutputEncoding = Encoding.Unicode;
            var ex07 = new Ex07_IEnumerable();
            ex07.display();
            Console.WriteLine("--------------Main------------");
            foreach (int number in new Ex07_IEnumerable())
            {
                Console.WriteLine(number);

            }
            Console.ReadKey();
        }
    }
}
