using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    class Samsung
    {
        string brand, oem, component;
        public Samsung() {
            brand = this.GetType().Name;
            oem = "Apple";
            component = "OLED pannels";
        }

        public void getOrders()
        {
            Console.WriteLine($"{brand} cung cap cho {oem} san pham {component}");
        }

        public void getOrders(string component,string oem)
        {
            Console.WriteLine($"+ cung cap {component} cho {oem}");
        }
    }
    internal class Ex01_OOP
    {
        static void Main(string[] args)
        {
            var ex01 = new Samsung();
            ex01.getOrders();
            ex01.getOrders("LCD pannel","Sony Xperia");
            ex01.getOrders(oem: "Sony", component: "LCD");

            Console.ReadKey();
        }
    }
}
