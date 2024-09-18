using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    internal class Ex03_Refkeyword
    {
        static void Giaodich(ref float giatri)
        {
            float laisuat = 0.1f;
            giatri += giatri * laisuat;
        }
        static void Main(string[] args)
        {
            float taikhoan = 1000f;
            Console.WriteLine($"Von ban dau {taikhoan}");

            //Giaodich(taikhoan);
            //Console.WriteLine($"Gia tri giao dich {taikhoan}");


            Giaodich(ref taikhoan);
            Console.WriteLine($"Gia tri giao dich {taikhoan}");

            Console.ReadKey();
        }
    }
}
