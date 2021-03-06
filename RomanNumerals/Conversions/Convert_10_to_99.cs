﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Conversions
{
    class Convert_10_to_99
    {
        public string ConvertIt(string input)
        {
            switch (input)
            {
                case "0":
                    return "";
                case "1":
                    return "X";
                case "2":
                    return "XX";
                case "3":
                    return "XXX";
                case "4":
                    return "XL";
                case "5":
                    return "L";
                case "6":
                    return "LX";
                case "7":
                    return "LXX";
                case "8":
                    return "LXXX";
                case "9":
                    return "XC";
                default:
                    return "broke";
            }
        }
    }
}
