using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_Constructs
{
    internal class Ex07_Jagged
    {
        static void Main(string[] args)
        {
            //int[][] arr = new int[2][];
            //arr[0] = new int[] { 1, 3, 5, 7, 9 };
            //arr[1] = new int[] { 2, 4, 6, 8 };

            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.Write($"Element[{i}]: ");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
                    
            //        Console.Write($"\t{arr[i][j]}");
            //    }
            //    Console.WriteLine();
            //}

            Array cities = Array.CreateInstance(typeof(String), 2);
            cities.SetValue("Ho Chi Minh",0);
            cities.SetValue("Hanoi capital", 1);
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ReadKey();
        }
    }
}
