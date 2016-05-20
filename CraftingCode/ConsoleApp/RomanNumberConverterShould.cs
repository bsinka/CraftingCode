using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CraftingCode.ConsoleApp
{
	public class RomanNumberConverterShould
	{
		[Fact]
		public void Roman1000()
		{
			Assert.Equal("M", RomanNumberConverter.ToRoman(1000));
		}

		[Fact]
		public void Roman1500()
		{
			Assert.Equal("MD", RomanNumberConverter.ToRoman(1500));
		}

		[Fact]
		public void Roman1400()
		{
			Assert.Equal("MCD", RomanNumberConverter.ToRoman(1400));
		}

		//[Fact]
		//public void Roman1900()
		//{
		//	Assert.Equal("MCM", RomanNumberConverter.ToRoman(1900));
		//}

		[Fact]
		public void Roman1600()
		{
			Assert.Equal("MDC", RomanNumberConverter.ToRoman(1600));
		}

		[Fact]
		public void Roman1700()
		{
			Assert.Equal("MDCC", RomanNumberConverter.ToRoman(1700));
		}

		[Fact]
		public void Roman2400()
		{
			Assert.Equal("MMCD", RomanNumberConverter.ToRoman(2400));
		}

		[Fact]
		public void Roman500()
		{
			Assert.Equal("D", RomanNumberConverter.ToRoman(500));
		}




		[Fact]
		public void Roman1750()
		{
			Assert.Equal("MDCCL", RomanNumberConverter.ToRoman(1750));
		}

		[Fact]
		public void Roman1770()
		{
			Assert.Equal("MDCCLXX", RomanNumberConverter.ToRoman(1770));
		}

		[Fact]
		public void Roman1775()
		{
			Assert.Equal("MDCCLXXV", RomanNumberConverter.ToRoman(1775));
		}

		[Fact]
		public void Roman1777()
		{
			Assert.Equal("MDCCLXXVII", RomanNumberConverter.ToRoman(1777));
		}
	}
}
