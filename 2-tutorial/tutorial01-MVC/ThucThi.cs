using System;


namespace Tutorial01_MVC
{
    internal class ThucThi
    {
        void menu()
        {
            Console.WriteLine("Menu");
            var ql = new QuanLy();
            ql.addNew();
            ql.display();
        }
        static void Main(string[] args)
        {
            var tt = new ThucThi(); 
            tt.menu();
            Console.ReadKey();
        }
    }
}
