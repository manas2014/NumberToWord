using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToWordConverter.Utility
{
    public static class Utilities
    {
        public static bool  IsValidateNumber(string number)
        {
            if (!int.TryParse(number, out var validNumber))
            {
                return false;
            }
            return true;
        }
        public static int ConvertToInteger(string number)
        {
            if (int.TryParse(number, out var validNumber))
            {
                return validNumber;
            }
            return 0;
        }
    }
}
