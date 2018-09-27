﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Conversions
{
    class Convert_1_to_9
    {
        public string ConvertIt(string input)
        {
            switch (input)
            {
                case "0":
                    return "";
                case "1":
                    return "I";
                case "2":
                    return "II";
                case "3":
                    return "III";
                case "4":
                    return "IV";
                case "5":
                    return "V";
                case "6":
                    return "VI";
                case "7":
                    return "VII";
                case "8":
                    return "VIII";
                case "9":
                    return "IX";
                default:
                    return "broke";
            }
        }
    }
}
