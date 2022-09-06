using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Converter_Console_Application
{
    /// <summary>
    /// Class <c>Converter</c>
    /// manage the convertion from roman numerals to numeric.
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Method <c>transform_roman_numeral_to_number</c>
        /// converts a roman numeral in number.
        /// if the convertion is not possible returns -1
        /// </summary>
        public int transform_roman_numeral_to_number(String roman_numeral)
        {
            var map = new Dictionary<Char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int res = 0;

            //if is not a roman numeral return -1
            foreach (char c in roman_numeral)
            {
                if (!map.ContainsKey(c)) return -1;
            }
            
            if (roman_numeral.Length == 1)
            {
                res = map[roman_numeral.ElementAt(0)];
            }
            else
            {
                for (int i = 0; i < roman_numeral.Length - 1; i += 1)
                {
                    if (i == roman_numeral.Length - 2)
                    {
                        if (map[roman_numeral.ElementAt(i)] >= map[roman_numeral.ElementAt(i + 1)])
                        {
                            res += map[roman_numeral.ElementAt(i)] + map[roman_numeral.ElementAt(i + 1)];
                        }
                        else
                        {
                            res += map[roman_numeral.ElementAt(i + 1)] - map[roman_numeral.ElementAt(i)];
                        }
                    }
                    else
                    {
                        if (map[roman_numeral.ElementAt(i)] >= map[roman_numeral.ElementAt(i + 1)])
                        {
                            res += map[roman_numeral.ElementAt(i)];
                        }
                        else
                        {
                            res += map[roman_numeral.ElementAt(i + 1)] - map[roman_numeral.ElementAt(i)];
                            i++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
