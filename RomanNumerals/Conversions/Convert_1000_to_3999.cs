using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Conversions
{
    class Convert_1000_to_3999
    {
        public string ConvertIt(string input)
        {
            switch (input)
            {
                case "0":
                    return "";
                case "1":
                    return "M";
                case "2":
                    return "MM";
                case "3":
                    return "MMM";
                default:
                    return "broke";
            }
        }
    }
}
