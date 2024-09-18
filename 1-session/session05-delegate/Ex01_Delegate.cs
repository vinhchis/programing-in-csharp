using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    internal class Ex01_Delegate
    {

        // 1. Delegate Declaration
        delegate void Uynhiem(int x, string y);

        // 2. Methods Declaration
        void lapPhieuChi(int sotien, string nhanvien) {
            
            Console.WriteLine($"Đã chi: {sotien}\nNgười lập phiếu: {nhanvien}");
        }

        void lapPhieuThu(int sotien, string nhanvien) {
            Console.WriteLine($"Đã thu: {sotien}\nNgười lập phiếu: {nhanvien}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int money;
            var ex01 = new Ex01_Delegate();
            Uynhiem phieuthu, phieuchi;
            phieuchi = ex01.lapPhieuChi;    // Literal
            phieuthu = new Uynhiem(ex01.lapPhieuThu); // Constructor

            // Lập phiếu chi
            Console.WriteLine("Nhập số tiền cần chi: ");
            money = Convert.ToInt16(Console.ReadLine());
            phieuchi(money,"LVA");

            // Lập phiếu thu
            Console.WriteLine("Nhập số tiền cần thu: ");
            money = Convert.ToInt16(Console.ReadLine());
            phieuthu(money, "TVB");

            Console.ReadKey();

        }
    }
}
