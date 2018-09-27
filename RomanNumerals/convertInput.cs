using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumerals.Conversions;

namespace RomanNumerals
{
    public class ConvertInput
    {
        public string ConvertNumberToRomanNumeral(int number) 
        {
            //Dictionary<int, string> NumToRoman = new Dictionary<int, string>()
            //{
            //    { 1, "I" },
            //    { 5, "V" },
            //    { 10, "X" },
            //    { 50, "L" },
            //    { 100, "C" }
            //    //{ 1, "I" },
            //    //{ 1, "I" },
            //};
            string convertedToRomanNumeral = "";
            string numberToCompare = number.ToString();

            for (int i = 0; i < numberToCompare.Length; i++)
            {
                if (i + 1 == 1) // 1 digit, 0-9
                {
                    var Convert_1_to_9 = new Convert_1_to_9();
                    string toBeConverted = "";
                    toBeConverted = numberToCompare[i].ToString();
                    var result = Convert_1_to_9.ConvertIt(toBeConverted);
                    convertedToRomanNumeral += result;
                }
                else if (i + 1 == 2) // 2 digits, 10-99
                {

                }
                else if (i + 1 == 3) // 3 digits, 100-999
                {

                }
            }
            return convertedToRomanNumeral;
            //if (inputNumber < 10)
            //{
            //    switch (inputNumber)
            //    {
            //        case 1:
            //            return "I";
            //        case 5:
            //            return "V";
            //        case 9:
            //            return "IX";
            //        default:
            //        {
            //            return "nope";
            //        }
            //    }
            //} else if (inputNumber < 100)
            //{

            //}
            //return "nope";
        }
    }
}
