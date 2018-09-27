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
        public void ConvertNumberToRomanNumeral(int inputNumber, string outputRomanNumeral)
        {
            //Arrange
            Dictionary<int, string> NumToRoman = new Dictionary<int, string>()
            {
                { 1, "I" },
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" }
                //{ 1, "I" },
                //{ 1, "I" },
            };
            var ConvertInput = new ConvertInput();

            //Act
            var ConvertedNumeral = ConvertInput.ConvertNumberToRomanNumeral(inputNumber);

            //Assert
            Assert.Equal(ConvertedNumeral, outputRomanNumeral);
        }
    }
}
