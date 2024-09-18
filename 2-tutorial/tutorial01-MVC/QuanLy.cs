using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01_MVC
{
    internal class QuanLy
    {   
        List<DoiTuong> ds= new List<DoiTuong>();
        
        public void addNew()
        {
            //DoiTuong doituong = new DoiTuong();
            //doituong.input();
            //ds.Add(doituong);
            ds.Add(new DoiTuong("001", "abc"));
            ds.Add(new DoiTuong("002", "xyz"));
        }
        public void display()
        {
            for(int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }
    }
}
