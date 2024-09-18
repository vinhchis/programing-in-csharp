using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Properties
{

    internal class Ex01_Field_Properties
    {
        private string java;
        private string csharp;

        string getJava()
        {
            return java;
        }

        void setJava(string value)
        {
            java = value;
        }
        // Ussing Properties - Block decleration
        public string CSharp
        {
            get
            {
                return csharp;
            }
            set { csharp = value; }
        }
        static void Main(string[] args)
        {
            Ex01_Field_Properties java, csharp;

            java = new Ex01_Field_Properties();
            java.setJava("Hello, How are you, Java");
            Console.WriteLine(java.getJava());

            csharp = new Ex01_Field_Properties();
            csharp.CSharp = "Hi, Test C# Properties";
            Console.WriteLine(csharp.CSharp);

            Console.ReadKey();

        }
    }
}
