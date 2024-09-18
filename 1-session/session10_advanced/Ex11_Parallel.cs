using System;
using System.Threading;
using System.Threading.Tasks;

namespace session10_Avanced
{
    internal class Ex11_Parallel
    {
        static void SimpleFor()
        {
            Console.WriteLine("Simple for loop: ");
            int number = 10;
            for (int i = 0; i < number; i++)
            {
                //Thread.CurrentThread.ManagedThreadId returns an integer that 
                //represents a unique identifier for the current managed thread.
                Console.WriteLine($"Thread = [{Thread.CurrentThread.ManagedThreadId}] with i = {i}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(500);
            }
        }

        static void ParallelFor()
        {
            Console.WriteLine("Parallel For loop: ");
            int number = 10;
            Parallel.For(0, number, i =>
            {
                Console.WriteLine($"Thread = [{Thread.CurrentThread.ManagedThreadId}] with i = {i}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(500);
            });
        }

        static void Main(string[] args)
        {
            SimpleFor();

            Console.WriteLine();

            ParallelFor();

            Console.ReadKey();
        }
    }
}
