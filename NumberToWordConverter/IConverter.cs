using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToWordConverter
{
    interface IConverter
    {
        string ConvertToWord(string number);
    }
}
