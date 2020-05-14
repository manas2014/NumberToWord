using NumberToWordConverter.Utility;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NumberToWordConverter
{
   public class NumberConverter : IConverter
    {
      
        private readonly string[] _numbers =
        {
            "Zero",
            "One",
            "Two",
            "Three",
            "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        private readonly string[] _tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public string ConvertToWord(string number)
        {
            return Utilities.IsValidateNumber(number)
                ? ConvertNumberToWord(Convert.ToInt32(number))
                : "Not a Valid Number";
        }
        private string ConvertNumberToWord(int number)
        {
            try
            {
                char[] digits = number.ToString().ToCharArray();
                string words = null;

                if (number >= 0 && number <= 19)
                {
                    words = words + this._numbers[number];
                }
                else if (number >= 20 && number <= 99)
                {
                    int firstDigit = (int)Char.GetNumericValue(digits[0]);
                    int secondPart = number % 10;

                    words = words + this._tens[firstDigit];

                    if (secondPart > 0)
                    {
                        words = words + " " + ConvertNumberToWord(secondPart);
                    }
                }
                else if (number >= 100 && number <= 999)
                {
                    int firstDigit = (int)Char.GetNumericValue(digits[0]);
                    int secondPart = number % 100;

                    words = words + this._numbers[firstDigit] + " hundred";

                    if (secondPart > 0)
                    {
                        words = words + "  " + ConvertNumberToWord(secondPart);
                    }
                }
                else if (number >= 1000 && number <= 19999)
                {
                    int firstPart = (int)Char.GetNumericValue(digits[0]);
                    if (number >= 10000)
                    {
                        string twoDigits = digits[0].ToString() + digits[1].ToString();
                        firstPart = Convert.ToInt16(twoDigits);
                    }
                    int secondPart = number % 1000;

                    words = words + this._numbers[firstPart] + " thousand";

                    if (secondPart > 0 && secondPart <= 99)
                    {
                        words = words + "  " + ConvertNumberToWord(secondPart);
                    }
                    else if (secondPart >= 100)
                    {
                        words = words + " " + ConvertNumberToWord(secondPart);
                    }
                }
                else if (number >= 20000 && number <= 999999)
                {
                    string firstStringPart = Char.GetNumericValue(digits[0]).ToString() + Char.GetNumericValue(digits[1]).ToString();

                    if (number >= 100000)
                    {
                        firstStringPart = firstStringPart + Char.GetNumericValue(digits[2]).ToString();
                    }

                    int firstPart = Convert.ToInt16(firstStringPart);
                    int secondPart = number - (firstPart * 1000);

                    words = words + ConvertNumberToWord(firstPart) + " thousand";

                    if (secondPart > 0 && secondPart <= 99)
                    {
                        words = words + "  " + ConvertNumberToWord(secondPart);
                    }
                    else if (secondPart >= 100)
                    {
                        words = words + " " + ConvertNumberToWord(secondPart);
                    }

                }
                else if (number == 1000000)
                {
                    words = words + "One million";
                }

                return words;
            }
            catch (Exception ex)
            {
                // return CustomException("Exception Occured");//Write Custom Exception
                return "Exception Occured";
            }
        }
    }
}
