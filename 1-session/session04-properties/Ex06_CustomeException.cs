using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Properties
{
    class MyException : Exception
    {
        public MyException(string s):base(s) {
            Console.WriteLine("Custom Exception!");
            Console.WriteLine("-------------------------------");
        }
    }

    class DBConnect
    {
        string cnn = "OK";
        public void makeConnection()
        {
            if(cnn == null) {
                throw new MyException("Connection fails!");
            }
            else
            {
                Console.WriteLine("Congratulations!");
            }
        }
    }
    internal class Ex06_CustomeException
    {
        static void Main(string[] args)
        {
            var cnn = new DBConnect();
            try
            {
                cnn.makeConnection();
            }
            catch (MyException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
