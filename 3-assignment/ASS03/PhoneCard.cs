using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASS03
{
    internal class PhoneCard
    {
        public string ServiceProviderName { get; set; }
        public string CardSeriNumber { get; set; }

        public void Input()
        {
            ServiceProviderName = Helper.Input("ServiceProviderName", @"^.+$", "ServiceProviderName is not null.");
            CardSeriNumber = Helper.Input("CardSeriNumber", @"^\d+$", "CardSeriNumber is digit only.");
        }

        public override string ToString()
        {
            return $"Service Provider Name: {ServiceProviderName}, Card Seri Number: {CardSeriNumber}";
        }
    }
}
