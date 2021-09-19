using NUnit.Framework;

namespace Kata_RomanNumerals
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertZero_IntoEmptyStr(object ArabToRomanConverter)
        {
            Assert.IsEmpty(ArabToRomanConverter.convert(0));
        }
    }
}