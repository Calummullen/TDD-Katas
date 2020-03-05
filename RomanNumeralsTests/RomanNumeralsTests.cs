using System.Collections;
using Kata;
using NUnit.Framework;

namespace RomanNumeralsTests
{
    public class RomanNumeralsTests
    {
        private RomanNumerals _romanNumerals;

/*        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1).Returns("I");
                yield return new TestCaseData(2).Returns("II");
                yield return new TestCaseData(3).Returns("III");
                yield return new TestCaseData(4).Returns("IV");
                yield return new TestCaseData(5).Returns("V");
                yield return new TestCaseData(9).Returns("IX");
                yield return new TestCaseData(21).Returns("XXI");
                yield return new TestCaseData(50).Returns("L");
                yield return new TestCaseData(100).Returns("C");
                yield return new TestCaseData(500).Returns("D");
                yield return new TestCaseData(1000).Returns("M");

            }
        }*/
        [SetUp]
        public void Setup()
        {
            _romanNumerals = new RomanNumerals();
        }

        [Test]
        public void ConverterReturnsString()
        {
            Assert.IsInstanceOf<string>(_romanNumerals.Convert(5));
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(21, "XXI")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        public void ConverterReturnsExpectedValue(int number, string expected)
        {
            var actual = _romanNumerals.Convert(number);
            Assert.AreEqual(actual, expected);
        }
    }
}