using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05_Delegate
{
    class MyGeneric<T>
    {
        T type;
        public MyGeneric(T type) {
            this.type = type;
        }

        public void display()
        {
            Console.WriteLine(this.type);
        }
    }
    internal class Ex06_Generic
    {
        static void Main(string[] args)
        {
            MyGeneric<string> name = new MyGeneric<string>("Hello, How old are you");
            MyGeneric<int> age = new MyGeneric<int>(90);
            name.display();
            age.display();

            Console.ReadKey();
        }
    }
}
