using System.Text;

namespace RomanNumeralConverter.Utilities
{
    public class CompareRomanNumbers
    {

        RomanToNumberConverterUtil romanToNumberConverterUtil = new RomanToNumberConverterUtil();

        public void compareNumbers(string roman1, string roman2) 
        {
            int result1 = romanToNumberConverterUtil.Convert(roman1);
            int result2 = romanToNumberConverterUtil.Convert(roman2);

            if (result1 == result2)
            {
                Console.WriteLine("Roman numeral 1: " + roman1 + " (" + result1 + ")");
                Console.WriteLine("Roman numeral 2: " + roman2 + " (" + result2 + ")");
                Console.WriteLine("Roman numerals are equal size.");
            }
            else if (result1 < result2)
            {
                Console.WriteLine("Roman numeral 1: " + roman1 + " (" + result1 + ")");
                Console.WriteLine("Roman numeral 2: " + roman2 + " (" + result2 + ")");
                Console.WriteLine("Roman numeral 2 is larger than Roman numeral 1.");
            }
            else 
            {
                Console.WriteLine("Roman numeral 1: " + roman1 + " (" + result1 + ")");
                Console.WriteLine("Roman numeral 2: " + roman2 + " (" + result2 + ")");
                Console.WriteLine("Roman numeral 1 is larger than Roman numeral 2.");
            }
        }
    }
}
