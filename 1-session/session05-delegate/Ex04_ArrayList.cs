using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    internal class Ex04_ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("Le Van A");
            list.Add(100);
            Console.WriteLine("Element list: ");
            foreach (object element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------Insert List------------------");
            list.Insert(0,"marks"); // Thêm element vào list ( java -> add(index,E e) )
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("------------------Remove List------------------");
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
