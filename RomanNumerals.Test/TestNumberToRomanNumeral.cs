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
            var ConvertInput = new ConvertInput();

            //Act
            var ConvertedNumeral = ConvertInput.ConvertNumberToRomanNumeral(inputNumber);

            //Assert
            Assert.Equal(ConvertedNumeral, outputRomanNumeral);
        }
    }
}
