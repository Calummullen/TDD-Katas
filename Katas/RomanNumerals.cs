using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class RomanNumerals
    {
        private readonly Dictionary<int, string> romanNumerals = new Dictionary<int, string>
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 21, "XXI" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" }
        };
        public string Convert(int number)
        {
            romanNumerals.TryGetValue(number, out var convertedValue);
            return !string.IsNullOrWhiteSpace(convertedValue) ? convertedValue : string.Empty;
        }
    }
}
