using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2_Array
{
    internal class QuanLy
    {
        int max, next;
        //static int max = 2;
        //DoiTuong[] doituong = new DoiTuong[max];
        DoiTuong[] doituong;
        public QuanLy()
        {
            max = 2;
            next = 0;
            doituong = new DoiTuong[max];
        }
        public void addNew()
        {
            doituong[next] = new DoiTuong();
            next++;
        }
        public void display()
        {
            if(next > 0)
            {
                for (int i = 0; i < next; i++)
                {
                    Console.WriteLine(doituong[i]);
                }
            }
            else
            {
                Console.WriteLine("Nothing to display");
            }
        }
    }
}
