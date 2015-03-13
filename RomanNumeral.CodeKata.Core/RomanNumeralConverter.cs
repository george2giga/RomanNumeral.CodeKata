using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral.CodeKata.Core
{
    public class RomanNumeralConverter
    {
        public int Convert(string romanNumeral)
        {
            var reversedRomans = new string(romanNumeral.Reverse().ToArray());
            int result = 0;
            int last = 0;
            for (int i = 0; i < reversedRomans.Count(); i++)
            {
                int numericValue = RomanToNumberValue(reversedRomans[i]);
                if (numericValue < last)
                {
                    result -= numericValue;
                }
                else
                {
                    result += numericValue;
                }

                last = numericValue;
            }

            return result;


        }



        public int RomanToNumberValue(char romanNumeral)
        {
            switch (romanNumeral)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }
            return 0;

        }
    }
}
