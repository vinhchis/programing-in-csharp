using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Ex02_OutputFormat
    {
        public static void Main(string[] args)
        {
            int money = 1_000_000;
            float rate = 3.5F;
            string name = "Lê Văn A";
            char ch = 'A';
            bool isOk;
            var note = "Implicit Types variables";

            //1. pass argument like Java
            Console.WriteLine("-1.");
            Console.WriteLine("String value of name: " + name);
            Console.WriteLine(note);
            //2. C# currency format
            Console.WriteLine("-2.");
            Console.WriteLine("Constant: {0:C}", 10);
            Console.WriteLine("Value of money: {0:C} and rate: {1}", money, rate);      //{...:C} định dạng tiền tệ

            //3. interpolated string (>= version 6.0)
            Console.WriteLine("-3.");
            Console.WriteLine($"{name} has {money}");
            Console.WriteLine($"{money:C} * {rate} = {(money * rate):C}");

            //4. String compare
            Console.WriteLine("-4. ");
            isOk = Char.ToUpper(ch).Equals('A');
            if (isOk) {
                Console.WriteLine("Welcome to my tutorial!");
            }
            else
            {

                Console.WriteLine(note);
            }

            //5. XML Comment

            Console.ReadKey();
        }
    }
}
