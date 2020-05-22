using System;
using Xunit;
using FakeItEasy;

namespace NumberToWordConverter.Test.UnitTests
{
    public class NumberToWordValidation
    {
        #region ConvertNumberToWord
        [Fact]
        public void ValidateOneDigitNumberToWord_Success()
        {

        }

        [Fact]
        public void ValidateTwoDigitNumberToWord_Success()
        {

        }

        [Fact]
        public void ValidateThreeDigitNumberToWord_Success()
        {

        }
        [Fact]
        public void ValidateFourDigitNumberToWord_Success()
        {

        }

        [Fact]
        public void ValidateNumber_Success()
        {
            var converter = new NumberConverter();
            var response = converter.ConvertToWord("123");
            Assert.Equal("One hundred  Twenty Three", response);
        }

        [Fact]
        public void ValidateNumber_Failure()
        {
            var converter = new NumberConverter();
            var errorResponse = converter.ConvertToWord("abc");
            Assert.Equal( "Not a Valid Number",errorResponse);

        }
        #endregion
    }
}
