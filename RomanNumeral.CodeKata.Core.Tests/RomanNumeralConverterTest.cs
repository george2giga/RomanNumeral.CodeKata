using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumeral.CodeKata.Core.Tests
{

    [TestFixture]
    public class RomanNumeralFixture
    {
        [TestCase("IV", 4)]
        [TestCase("III", 3)]
        [TestCase("IX", 9)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("VI", 6)]
        [TestCase("X", 10)]
        [TestCase("LXIV", 64)]
        [TestCase("LXXVIII", 78)]
        [TestCase("MMDLXIV", 2564)]
        [TestCase("XCVIII", 98)]
        [TestCase("XCVII", 97)]
        [TestCase("MCMXCVI", 1996)]
        [TestCase("MCMXCVIII", 1998)]
        [TestCase("MMXVIII", 2018)]
        public void Convert_Serie_Of_Romans_Correctly(string roman, int expected)
        {
            var romanConverter = new RomanNumeralConverter();
            var result = romanConverter.Convert(roman);
            Assert.AreEqual(expected, result);
        }
    }
}
