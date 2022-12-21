using RomanNumeralConverter.Utilities;

class Converter
{
    static void Main(string[] args)
    {
        while (true) 
        {
            Converter.Title();
            int numberToConvert;
            bool success = Int32.TryParse(Console.ReadLine(), out numberToConvert);
            if (success)
            {
                if (numberToConvert > 4 || numberToConvert < 1)
                {
                    Console.WriteLine("Inputted number must be in range from 1 to 4");
                }
                else
                {
                    if (numberToConvert == 1) 
                    {
                        Converter.convertIntToRoman();
                    }
                    else if (numberToConvert == 2)
                    {
                        Converter.convertRomanToInt();
                    }
                    else if (numberToConvert == 3)
                    {
                        Converter.compareRomanNumber();
                    }
                    else if (numberToConvert == 4)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please input valid Integer between 1-4");
            }
        }
    } 
    private static void Title() 
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Roman Numeral Converter:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("1. Convert integer to Roman numerals");
        Console.WriteLine("2. Convert Roman numerals to integer");
        Console.WriteLine("3. Compare two Roman numerals");
        Console.WriteLine("4. Exit");
    }

    private static void convertIntToRoman() 
    {

        NumberToRomanConverterUtil numberToRomanConverterUtil = new NumberToRomanConverterUtil();

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Convert integer to Roman numerals:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Input a number between 1-3999 to convert to Roman numerals:");

        int numberToConvert;

        bool success = Int32.TryParse(Console.ReadLine(), out numberToConvert);

        if (success)
        {
            if (numberToConvert > 3999 || numberToConvert < 1)
            {
                Console.WriteLine("Inputted number must be in range from 1 to 3999");
            }
            else
            {
                string result = numberToRomanConverterUtil.Convert(numberToConvert);
                Console.WriteLine("Number " + numberToConvert + " as Roman Numerals: " + result);
            }
        }
        else
        {
            Console.WriteLine("Please input valid Integer between 1-3999");
        }
    }

    private static void convertRomanToInt()
    {

        RomanToNumberConverterUtil romanToNumberConverterUtil = new RomanToNumberConverterUtil();

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Convert Roman numerals to integer:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Input a Roman numeral between 1-3999 to convert to integer:");

        string romanToConvert = Console.ReadLine();

        bool success = romanToNumberConverterUtil.checkRomanNumber(romanToConvert);

        if (success)
        {
            int result = romanToNumberConverterUtil.Convert(romanToConvert);
            Console.WriteLine("Roman numerals " + romanToConvert + " as integer: " + result);
        }
        else
        {
            Console.WriteLine("Please input valid Roman numerals");
        }
    }

    private static void compareRomanNumber()
    {

        CompareRomanNumbers compareRomans = new CompareRomanNumbers();
        RomanToNumberConverterUtil romanToNumberConverterUtil = new RomanToNumberConverterUtil();

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Compare Roman numerals:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Input the first Roman numeral between 1-3999 to compare:");

        string romanToConvert1 = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Input the second Roman numeral between 1-3999 to compare:");

        string romanToConvert2 = Console.ReadLine();

        bool success = romanToNumberConverterUtil.checkRomanNumber(romanToConvert1);
        success = romanToNumberConverterUtil.checkRomanNumber(romanToConvert2);

        if (success)
        {
            compareRomans.compareNumbers(romanToConvert1, romanToConvert2);
        }
        else
        {
            Console.WriteLine("Please input valid Roman numerals");
        }
    }

}