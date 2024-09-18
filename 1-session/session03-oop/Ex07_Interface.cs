using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    interface User1
    {
        void select(string tableName);
    }
    interface User2
    {
        void select(string tableName);
        void update(int rate,string code);
        void delete(string code);
    }
    internal class Ex07_Interface:User1,User2
    {
        public void select(string tableName) {
            Console.WriteLine($"select * from {tableName}");
        }

        public void update(int rate,string code)
        {
            Console.WriteLine($"update Item set Rate = {rate} where Code = {code}");
        }
        public void delete(string code)
        {
            Console.WriteLine($"delete Item where Code = {code}");
        }
        static void Main(string[] args)
        {
            User1 user1 = new Ex07_Interface();
            User2 user2 = new Ex07_Interface();
            user1.select("StrongHold");
            user2.select("tbMovies");
            user2.update(100,"Pokemon");
            user2.delete("Pokemon");

            Console.ReadKey();
            
        }
    }
}
