using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03_OOP
{
    internal class Ex04_Outkeyword
    {
        static void Giaodich(out float giatri)
        {
            giatri = 1000f;
            float laisuat = 0.1f;
            giatri += giatri * laisuat;
        }

        static void Main(string[] args)
        {
            float taikhoan = 0;
            Console.WriteLine($"Von ban dau {taikhoan}");

            //Giaodich(taikhoan);
            //Console.WriteLine($"Gia tri giao dich {taikhoan}");


            Giaodich(out taikhoan);
            Console.WriteLine($"Gia tri giao dich {taikhoan}");

            Console.ReadKey();
        }
    }
}
