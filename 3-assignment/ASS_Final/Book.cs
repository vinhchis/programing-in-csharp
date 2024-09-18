using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASS_Final
{
    internal class Book : Library
    {
        private string? _title;
        private double _price;
        private bool _isSale;

        public string? Title
        {
            get { return _title; }
            set
            {
                string rg = @"^([a-zA-Z]|[0-9]|\s)*$";
                //string rg = @"\w+";
                if(Regex.IsMatch(value, rg)){
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("Title only contains letter, digits and white space");
                }
                
            }
        }


        public double Price { 
            get { return _price; }
            set { 
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be great than zero");
                }
            } 
        }

        public bool IsSale
        {
            get
            {
                return _isSale;
            }
            set
            {
               _isSale = value;
            }
        }

        public override void BookInfo()
        {
            Console.WriteLine($"Book Infor: {this}");
        }

        public override string ToString()
        {
            string s;
            if (_isSale)
            {
                s = "Sale";
            }
            else
            {
                s = "Not Sale";
            }
            return $"title: {_title}, price: {_price}, {s}";
        }
    }
}
