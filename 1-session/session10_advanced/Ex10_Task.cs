using System;
using System.Threading.Tasks;

namespace session10_Avanced
{
    internal class Ex10_Task
    {
        static async Task Writter()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"1.{i + 1}. (Writting) into file\n");
                    Task.Delay(500).Wait();
                }
            });
        }

        static async Task Reader()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"2.{i + 1}. Reading into file\n");
                    Task.Delay(500).Wait();
                }
            });
        }

        //static void Reader()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"2.{i + 1}. Reading from file\n");
        //        Task.Delay(500).Wait();
        //    }
        //    Console.WriteLine("\n");
        //}
        static void Main(string[] args)
        {
            Writter();
            Reader();

            Console.ReadKey();
        }
    }
}