using System;
using System.Threading;
using System.Threading.Tasks;

namespace session10_Avanced
{
    internal class Ex09_Thread
    {
        static void Writter()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"1.{i + 1}. (Writting) into file\n");
                Thread.Sleep(100);
            }
        }

        static void Reader()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"2.{i + 1}. Reading from file\n");
                Thread.Sleep(500);
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Reader));
            thread.Start();

            Action action = new Action(Writter);
            Task task = new Task(action);
            task.Start();

            Console.ReadKey();
        }
    }
}