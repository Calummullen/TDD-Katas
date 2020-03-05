using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var replaceNonNumbers = numbers
                .Split(new[] {" ", ",", "\n", ";", "//", "[***]", "*", "%", "***", "[*]", "[%]"}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var numbersList = replaceNonNumbers.Select(int.Parse);
            if (numbersList.Any(number => number < 0)) throw new Exception("Negatives are not allowed");
            return numbersList.Where(number => number < 1000).Sum();
        }
    }
}
