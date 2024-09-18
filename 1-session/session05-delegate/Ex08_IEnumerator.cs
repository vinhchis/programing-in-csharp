using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    internal class Ex08_IEnumerator
    {
        int[] num = {1,2,3,4,5,6,7,8,9,10 };
        public Ex08_IEnumerator()
        {
            IEnumerator iterator = num.GetEnumerator();
            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }

        static void Main(string[] args)
        {
            new Ex08_IEnumerator();

            Console.ReadKey();
        }
    }
}
