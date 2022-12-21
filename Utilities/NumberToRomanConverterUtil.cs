using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter.Utilities
{
    public class NumberToRomanConverterUtil
    {
        public enum singleDigits
        {
            I = 1,
            II = 2,
            III = 3,
            IV = 4,
            V = 5,
            VI = 6,
            VII = 7,
            VIII = 8,
            IX = 9
        }

        public enum tenDigits
        {
            X = 1,
            XX = 2,
            XXX = 3,
            XL = 4,
            L = 5,
            LX = 6,
            LXX = 7,
            LXXX = 8,
            XC = 9
        }

        public enum hundredDigits
        {
            C = 1,
            CC = 2,
            CCC = 3,
            CD = 4,
            D = 5,
            DC = 6,
            DCC = 7,
            DCCC = 8,
            CM = 9
        }
        public enum thousandDigits
        {
            M = 1,
            MM = 2,
            MMM = 3
        }
        public string Convert(int number)
        {

            string romanNumber = "";
            List<int> digits = GetDigits(number);
            int numberLength = number.ToString().Length;
            if (numberLength > 4)
            {
                Console.WriteLine("Maximum number you can convert is 3999!");
            }
            else 
            {
                int position = numberLength;

                for (int i = 0; i < numberLength; i++)
                {
                    string tempNumber = convertDigit(digits.ElementAt(i), position);
                    romanNumber += tempNumber;
                    position--;
                }
            }

            return romanNumber;
        }

        private string convertDigit(int digit, int position) 
        {
            if (position == 1)
            {
                return Enum.GetName(typeof(singleDigits), digit);
            } 
            else if (position == 2) 
            {
                return Enum.GetName(typeof(tenDigits), digit);
            }
            else if (position == 3)
            {
                return Enum.GetName(typeof(hundredDigits), digit);
            }
            else if (position == 4)
            {
                return Enum.GetName(typeof(thousandDigits), digit);
            }
            return "";
        }

        private List<int> GetDigits(int input)
        {
            int currentNumber = input;
            List<int> digits = new List<int>();
            while (currentNumber != 0)
            {
                digits.Add(currentNumber % 10);
                currentNumber = currentNumber / 10;
            }
            digits.Reverse();
            return digits;
        }
    }
}
