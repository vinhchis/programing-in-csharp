using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04_Properties
{
    abstract class Table
    {
        // Abstract read-only Properties
        public abstract string TableName { get; }
    }
    internal class Ex02_Properties: Table
    {
        private string code; // shorcut: propfull
        private string s = "Item";
        // Using Block declaration
        public string Code
        {
            get
            {
                return code
                    ;
            }
            set
            {
                code = value;
            }
            
        }

        // Using Auto implemented Properties ( shorcut: prop )
        public string Name { get; set; }
        public int Price { get; set; }

        // Overide properties
        public override string TableName
        {
            get
            {
                return s;
            }
        }

        public override string ToString()
        {
            return $"Table: {TableName} \nCode: {Code} \nName: {Name} \nPrice: {Price}";
        }
        static void Main(string[] args)
        {
            var ex02 = new Ex02_Properties {
                Code = "RKSK-T",
                Name = "Ruckstack Tan",
                Price = 500
            };
            
            Console.WriteLine(ex02);
            Console.ReadKey();
        }
    }
}
