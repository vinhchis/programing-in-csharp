using System;


namespace Session01
{
    internal class Ex01_JavaVSCSharp
    {
        public static void Main(string[] args)
        {
            string name = "Le Van A";
            int money = 1000000;

            string s = $"{name} co {money} USD";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
