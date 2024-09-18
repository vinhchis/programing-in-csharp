using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Constructs
{
    internal class Ex06_Array
    {
        static void Main(string[] args)
        {
            //int[] odd = { 1, 3, 5, 7, 9 };
            //for(int i = 0; i < odd.Length; i++)
            //{
            //    Console.Write(odd[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("====================");

            //int[] even = { 2, 4, 6, 8, 10 };
            //foreach(int element in even) {  Console.Write(element); }
            //Console.WriteLine();

            //int[] single = new int[3];

            //for(int i = 0; i<single.Length; i++)
            //{
            //    Console.WriteLine($"Enter value {i+1}: ");
            //    single[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Using new key word only");
            //foreach (var element in single) { Console.Write("\t" + element); }

            Console.WriteLine();

            int[,] init = { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach(var element in init) { Console.Write("\t" + element); }
            Console.WriteLine();

            int[][] nested = { new int[] { 111, 222, 333 }, new int[] {444,555,666 } };
            foreach (int[] tmp  in nested) { foreach (var element in tmp) {
                    Console.Write("\t" + element);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] multi = new int[2, 3];
            for (int i = 0; i < multi.GetLength(0); i++) {
                
                for(int j = 0; j < multi.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value {i + 1}: ");
                    multi[i, j] = int.Parse(Console.ReadLine());
                }
            }

            foreach (var tmp in multi) {
                Console.Write("\t" + tmp);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
