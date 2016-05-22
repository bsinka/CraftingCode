using Xunit;

namespace RomanNumeralConverter
{
    public class RomanNumeralConverterTest
	{
		[Fact]
		public void Convert1()
		{
			Assert.Equal("I", RomanNumeralConverter.ToRoman(1));
		}

        [Fact]
        public void Convert2()
        {
            Assert.Equal("II", RomanNumeralConverter.ToRoman(2));
        }

        [Fact]
        public void Convert3()
        {
            Assert.Equal("III", RomanNumeralConverter.ToRoman(3));
        }

        [Fact]
        public void Convert5()
        {
            Assert.Equal("V", RomanNumeralConverter.ToRoman(5));
        }

        [Fact]
        public void Convert8()
        {
            Assert.Equal("VIII", RomanNumeralConverter.ToRoman(8));
        }

        [Fact]
        public void Convert17()
        {
            Assert.Equal("XVII", RomanNumeralConverter.ToRoman(17));
        }

        [Fact]
        public void Convert30()
        {
            Assert.Equal("XXX", RomanNumeralConverter.ToRoman(30));
        }

        [Fact]
        public void Convert2678()
        {
            Assert.Equal("MMDCLXXVIII", RomanNumeralConverter.ToRoman(2678));
        }

        [Fact]
        public void Convert2949()
        {
            Assert.Equal("MMCMXLIX", RomanNumeralConverter.ToRoman(2949));
        }
    }
}
