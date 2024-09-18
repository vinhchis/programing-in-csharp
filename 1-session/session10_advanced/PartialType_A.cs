using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal partial class PartialType<T>
    {
        public T Code { get; set; }
        public T Name { get; set; }

        partial void Display(); // giống như 1 interface

        public override string ToString()
        {
            return $"Code = {Code}, Name = {Name}";
        }
    }
}
