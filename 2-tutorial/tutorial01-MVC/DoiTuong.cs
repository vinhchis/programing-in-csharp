using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01_MVC
{
    internal class DoiTuong
    {
        String code, name;
        public DoiTuong(String code, String name) {
            this.code = code;
            this.name = name;
        }
        public DoiTuong() { }
        public void input()
        {
            Console.WriteLine("Enter code: ");
            code = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            
        }
        
        public override String ToString()
        {
            return code + " - " + name;
        }
    }
}
