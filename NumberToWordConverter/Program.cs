using System;
namespace NumberToWordConverter
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");

            var number = Console.ReadLine();
            IConverter converter = new NumberConverter();

            Console.WriteLine(converter.ConvertToWord(number));

            Console.WriteLine("Press Enter To Exit");
            Console.Read();
        }
    }
}
