using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ConvertInput
    {
        public string ConvertNumberToRomanNumeral(int inputNumber) 
        {
            // new class for 0-9
            //               10-99
            //               100-999
            if (inputNumber < 10)
            {
                switch (inputNumber)
                {
                    case 1:
                        return "I";
                    case 5:
                        return "V";
                    case 9:
                        return "IX";
                    default:
                    {
                        return "nope";
                    }
                }
            } else if (inputNumber < 100)
            {

            }
            return "nope";
        }
    }
}
