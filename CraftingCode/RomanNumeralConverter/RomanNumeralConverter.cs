using System;
using System.Collections.Generic;

namespace RomanNumeralConverter
{
    public static class RomanNumeralConverter
	{
        private static List<Tuple<int, string>> Map = new List<Tuple<int, string>>()
        {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400, "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };

		public static string ToRoman(int value)
		{
            string roman = string.Empty;

            foreach (var item in Map)
            {
                while (value >= item.Item1)
                {
                    roman += item.Item2;
                    value -= item.Item1;
                }
            }

            return roman;
		}
	}
}
