using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    static class NoInstance
    {
        public static void say()
        {
            Console.WriteLine("Welcome to static class NoInstance");
        }
    }
    internal class Ex02_Static 
    {
        static string val = "value of static field";
        void nonStaticMethod()
        {
            Console.WriteLine("Non static!");
        }

        static void staticMethod() {
            Console.WriteLine("Static");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(val);
            var ex02 = new Ex02_Static();
            ex02.nonStaticMethod();
            staticMethod();
 
            NoInstance.say(); //NoInstance test = new NoInstance();

            Console.ReadKey();
        }
    }
}
