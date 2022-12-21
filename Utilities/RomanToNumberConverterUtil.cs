using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter.Utilities
{
    public class RomanToNumberConverterUtil
    {

        public int Convert(string romanNumerals)
        {

            int resultInteger = 0;

            char[] digits = romanNumerals.ToCharArray();
            int numberLength = digits.Length;

            for (int i = 0; i < numberLength; i++)
            {
                int tempNumber = convertDigit(digits, i, numberLength);
                resultInteger += tempNumber;
                if (tempNumber == 900 || tempNumber == 400 || tempNumber == 90 || tempNumber == 40 || tempNumber == 9 || tempNumber == 4)
                {
                    i++;
                }
            }

            return resultInteger;
        }

        private int convertDigit(char[] digit, int position, int arrayLength) 
        {
            try
            {
                if (digit[position] == 'M') 
                {
                    return 1000;
                }
                if (digit[position] == 'D')
                {
                    return 500;
                }
                if (digit[position] == 'C')
                {
                    if (position + 1 < arrayLength)
                    {
                        if (!(digit[position + 1] == 'D') && !(digit[position + 1] == 'M'))
                        {
                            return 100;
                        }
                        else if (digit[position + 1] == 'M')
                        {
                            return 900;
                        }
                        else if (digit[position + 1] == 'D')
                        {
                            return 400;
                        }
                    }
                    else
                    {
                        return 100;
                    }
                }
                if (digit[position] == 'L')
                {
                    return 50;
                }
                if (digit[position] == 'X')
                {
                    if (position + 1 < arrayLength)
                    {
                        if (!(digit[position + 1] == 'C') && !(digit[position + 1] == 'L'))
                        {
                            return 10;
                        }
                        else if (digit[position + 1] == 'C')
                        {
                            return 90;
                        }
                        else if (digit[position + 1] == 'L')
                        {
                            return 40;
                        }
                    }
                    else
                    {
                        return 10;
                    }
                }
                if (digit[position] == 'V')
                {
                    return 5;
                }
                if (digit[position] == 'I')
                {
                    if (position + 1 < arrayLength)
                    {
                        if (!(digit[position + 1] == 'X') && !(digit[position + 1] == 'V'))
                        {
                            return 1;
                        }
                        else if (digit[position + 1] == 'X')
                        {
                            return 9;
                        }
                        else if (digit[position + 1] == 'V')
                        {
                            return 4;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            { 
            }

            return 0;
        }
        public bool checkRomanNumber(string input)
        {
            List<string> checkedValues = new List<string>(){ "A","B","E","F","G","H","J","K","N","O","P","Q","R","S","T","U","W","Y","Z","0","1","2","3","4","5","6","7","8","9",".",",",";",":","*","#"};
            foreach (string checkedValue in checkedValues)
            {
                if (input.Contains(checkedValue))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
