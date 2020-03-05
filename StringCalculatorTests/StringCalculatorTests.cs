using System;
using NUnit.Framework;
using Kata;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;
        [SetUp]
        public void Setup()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void EmptyStringWillReturnZero()
        {
            Assert.AreEqual(0, _stringCalculator.Add(""));
        }

        [Test]
        public void StringWithNumberWithLengthOf1ReturnsTheNumber()
        {
            Assert.AreEqual(1, _stringCalculator.Add("1"));
            Assert.AreEqual(9, _stringCalculator.Add("9"));
        }

        [Test]
        public void StringWithNumberOfAnyLengthReturnsTheNumber()
        {
            Assert.AreEqual(123, _stringCalculator.Add("123"));
        }

        [Test]
        public void StringWith1NumberAndACommaReturnsTheNumber()
        {
            Assert.AreEqual(45, _stringCalculator.Add("45,"));
            Assert.AreEqual(999, _stringCalculator.Add("999,"));
        }

        [Test]
        public void StringWith2NumbersReturnsTheSumOfBothNumbers()
        {
            Assert.AreEqual(25, _stringCalculator.Add("10,15"));
            Assert.AreEqual(977, _stringCalculator.Add("46,931"));
        }

        [Test]
        public void StringWithMultipleNumbersReturnsTheSumOfAllNumbers()
        {
            Assert.AreEqual(448, _stringCalculator.Add("10,15,400,23"));
            Assert.AreEqual(992, _stringCalculator.Add("46,931,1,2,3,4,5"));
        }

        [Test]
        public void StringWithNewLinesReturnsCorrectSum()
        {
            Assert.AreEqual(6, _stringCalculator.Add("1\n2,3"));
        }

        [Test]
        public void StringWithDifferentDelimetersAreSummedCorrectly()
        {
            Assert.AreEqual(3, _stringCalculator.Add(";\n1;2"));
        }

        [Test]
        public void StringWithDifferentLengthDelimetersIsSummedCorrectly()
        {
            Assert.AreEqual(6, _stringCalculator.Add("//[***]\n1***2***3"));
            Assert.AreEqual(676, _stringCalculator.Add("//[***]\n100***200***376"));
        }

        [Test]
        public void StringWithMultipleDelimetersIsSummedCorrectly()
        {
            Assert.AreEqual(6, _stringCalculator.Add("//[*][%]\n1*2%3"));
        }

        [Test]
        public void StringWithMultipleAndDifferentDelimetersIsSummedCorrectly()
        {
            Assert.AreEqual(6, _stringCalculator.Add("//[***]*****[***][%]\n1*2[***][%]%3"));
        }

        [Test]
        public void StringWithNegativeNumberThrowsException()
        {
            Assert.Throws<Exception>(() => _stringCalculator.Add("1,2,-3,4"));
        }

        [Test]
        public void StringOnlySumsNumbersLessThan1000()
        {
            Assert.AreEqual(20, _stringCalculator.Add("15,5,1000"));
            Assert.AreEqual(1019, _stringCalculator.Add(";15,5,\n1000, 999"));
        }
    }
}