using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingCode.ConsoleApp
{
	public static class RomanNumberConverter
	{
		private static int MAX_REPETITIONS = 3;

		public static string ToRoman(int number)
		{
			// M = 1000
			string romanNumber = string.Empty;
			int m = number / 1000;
			for (int i = 0; i < m; i++)
			{
				romanNumber += "M";
			}

			number = number - (m * 1000);

			// D = 500
			int d = number / 500;
			if (d > 0)
			{
				romanNumber += "D";
				number = number - 500;
			}

			// C = 100
			//int c = number / 100;
			//if (c > MAX_REPETITIONS)
			//{
			//	romanNumber += "CD";
			//}
			//else
			//{
			//	for (int i = 0; i < c; i++)
			//	{
			//		romanNumber += "C";
			//	}
			//}
			//number = number - (c * 100);

			romanNumber += GetRepeatableSimbolSequence(
				ref number, 100, "C", "D");

			// D = 50
			int l = number / 50;
			if (l > 0)
			{
				romanNumber += "L";
				number = number - 50;
			}

			// X = 10
			//int x = number / 10;
			//for (int i = 0; i < x; i++)
			//{
			//	romanNumber += "X";
			//}

			//number = number - (x * 10);
			romanNumber += GetRepeatableSimbolSequence(ref number, 10, "X", "V");

			// V = 5
			int v = number / 5;
			if (v > 0)
			{
				romanNumber += "V";
				number = number - 5;
			}

			// I = 1
			int I = number;
			for (int i = 0; i < I; i++)
			{
				romanNumber += "I";
			}

			number = number - I;

			return romanNumber;
		}

		private static string GetRepeatableSimbolSequence(
			ref int number,
			int symbolValue,
			string symbol,
			string greaterSymbol)
		{
			string romanNumberSequence = string.Empty;

			int c = number / symbolValue;
			if (c > MAX_REPETITIONS)
			{
				romanNumberSequence += symbol + greaterSymbol;
			}
			else
			{
				for (int i = 0; i < c; i++)
				{
					romanNumberSequence += symbol;
				}
			}

			number -= c * symbolValue;

			return romanNumberSequence;
		}
	}
}
