using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    abstract class DB
    {
        protected string code, name;
        protected int price;
        protected DB(string code, string name, int price) { 
            this.code = code;
            this.name = name;
            this.price = price;
        }
        public abstract void select();
    }
    internal class Ex06_Abstract:DB
    {
        public Ex06_Abstract(string code, string name, int price):base(code,name,price) {}
        public override void select() {
            Console.WriteLine("Item information");
            Console.WriteLine($"{code} - {name} - {price}");
        }
        static void Main(string[] args)
        {
            var ex06 = new Ex06_Abstract("001","Apple",100);
            ex06.select();
            Console.ReadKey();
        }
    }
}
