using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Database
{
    internal class Item
    {
        public string Code {  get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(string code, string name, int price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public Item() {
            Code = "";
            Name = "";
            Price = -1;
        }
        public void input()
        {
            Console.Write("Enter code: ");
            while (true)
            {
                Code = Console.ReadLine();
                if (!String.IsNullOrEmpty(Code))
                {
                    break;
                }
            }

            Console.Write("Enter name: ");
            while (true)
            {
                Name = Console.ReadLine();
                if(String.IsNullOrEmpty(Name))
                {
                    break;
                }
            }

            Console.Write("Enter price: ");
            Price = Convert.ToInt32(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"code: {Code}, name: {Name}, price: {Price}$";
        }
    }
}
