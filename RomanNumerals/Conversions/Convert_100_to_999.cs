using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Conversions
{
    class Convert_100_to_999
    {
        public string ConvertIt(string input)
        {
            switch (input)
            {
                case "0":
                    return "";
                case "1":
                    return "C";
                case "2":
                    return "CC";
                case "3":
                    return "CCC";
                case "4":
                    return "CD";
                case "5":
                    return "D";
                case "6":
                    return "DC";
                case "7":
                    return "DCC";
                case "8":
                    return "DCCC";
                case "9":
                    return "CM";
                default:
                    return "broke";
            }

            
        }
    }
}
