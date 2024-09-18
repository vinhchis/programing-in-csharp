using System;
using ABC = YourSpace;
// 1. Other Name space
namespace YourSpace
{
    public class YourCompany
    {
        public static void design()
        {
            Console.WriteLine("Design by ACB Corporation");
        }
    }
}


// 3. Main space
namespace Session04_Properties
{
    // 2. Nested class
    namespace NestedSpace
    {
        class MyCompany
        {
            public void callService()
            {
                Console.WriteLine($"The NameSpace: {typeof(MyCompany).Namespace}");
            }
        }
    }
    class MyCompany
    {
        public void callService()
        {
            Console.WriteLine($"The NameSpace: {typeof(MyCompany).Namespace}");
        }
    }

    internal class Ex04_NameSpace
    {
        static void Main(string[] args)
        {
            var outer = new MyCompany();
            outer.callService();

            NestedSpace.MyCompany inner = new NestedSpace.MyCompany();
            inner.callService();

            ABC.YourCompany.design();
            Console.ReadKey();
        }
    }
}
