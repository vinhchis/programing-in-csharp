﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASS_Final
{
    internal static class Helper
    {
        public static string Input(string name, string rg, string message)
        {
            while (true)
            {
                try {
                    Console.WriteLine($"Enter {name}: ");
                    string s = Console.ReadLine().Trim();

                    if (!Regex.IsMatch(s, rg))
                    {
                        Console.WriteLine($"Error: {message}");
                    }
                    else
                    {
                        return s;
                    }

                } 
                catch (Exception e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                
            }
        }
    }
}