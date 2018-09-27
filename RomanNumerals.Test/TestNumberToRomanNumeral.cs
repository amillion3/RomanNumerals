using System;
using Xunit;
using System.Collections.Generic;

namespace RomanNumerals.Test
{
    public class TestNumberToRomanNumeral
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        public void ConvertNumberToRomanNumeral(int inputNumber, string outputRomanNumeral)
        {
            //Arrange
            var ConvertInput = new ConvertInput();

            //Act
            var ConvertedNumeral = ConvertInput.ConvertNumberToRomanNumeral(inputNumber);

            //Assert
            Assert.Equal(ConvertedNumeral, outputRomanNumeral);
        }
    }
}
