using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_Advanced
{
    internal partial class PartialType<T>
    {
        public PartialType(T code, T name)
        {
            Code = code;
            Name = name;
        }
    }
}
