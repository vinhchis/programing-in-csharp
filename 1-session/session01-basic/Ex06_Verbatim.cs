using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session01
{
    internal class Ex06_Verbatim
    {
        static void Main(string[] args)
        {
            string email, reMail;
            reMail = @"^[A-Za-z]\w+[@]\w+[.]\w{3}([.]\w{2})?$";
            bool isOK;
            while (true)
            {
                Console.WriteLine("Enter email for register: ");
                email = Console.ReadLine();
                isOK = Regex.IsMatch(email, reMail);
                if (isOK)
                {
                    Console.WriteLine("Register Successfully!");
                    Console.WriteLine($"Email: {email}");
                    break;
                }
                else
                {
                    Console.Error.WriteLine("Email is Invalid!");
                }
            }
            Console.ReadKey();
        }
    }
}
