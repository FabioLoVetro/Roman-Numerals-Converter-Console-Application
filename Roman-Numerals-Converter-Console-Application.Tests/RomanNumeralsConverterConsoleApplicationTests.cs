using NUnit.Framework;
using FluentAssertions;
using Exercises.Models;
using System.Collections.Generic;
using System;

namespace Roman_Numerals_Converter_Console_Application.Tests
{
    public class RomanNumeralsConverterConsoleApplicationTests
    {
        private Converter converter;

        [SetUp]
        public void Setup()
        {
            converter = new Converter();
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_-1_for_letters_not_roman_numeral()
        {
            converter.transform_roman_numeral_to_number("a").Should().Be(-1);
            converter.transform_roman_numeral_to_number("B").Should().Be(-1);
            converter.transform_roman_numeral_to_number("e").Should().Be(-1);
            converter.transform_roman_numeral_to_number("F").Should().Be(-1);
            converter.transform_roman_numeral_to_number("g").Should().Be(-1);
            converter.transform_roman_numeral_to_number("J").Should().Be(-1);
            converter.transform_roman_numeral_to_number("k").Should().Be(-1);
            converter.transform_roman_numeral_to_number("n").Should().Be(-1);
            converter.transform_roman_numeral_to_number("O").Should().Be(-1);
            converter.transform_roman_numeral_to_number("p").Should().Be(-1);
            converter.transform_roman_numeral_to_number("Q").Should().Be(-1);
            converter.transform_roman_numeral_to_number("r").Should().Be(-1);
            converter.transform_roman_numeral_to_number("S").Should().Be(-1);
            converter.transform_roman_numeral_to_number("t").Should().Be(-1);
            converter.transform_roman_numeral_to_number("U").Should().Be(-1);
            converter.transform_roman_numeral_to_number("v").Should().Be(-1);
            converter.transform_roman_numeral_to_number("W").Should().Be(-1);
            converter.transform_roman_numeral_to_number("y").Should().Be(-1);
            converter.transform_roman_numeral_to_number("Z").Should().Be(-1);
            converter.transform_roman_numeral_to_number("aB").Should().Be(-1);
            converter.transform_roman_numeral_to_number("aBeFg").Should().Be(-1);
            converter.transform_roman_numeral_to_number(null).Should().Be(-1);
            converter.transform_roman_numeral_to_number(" ").Should().Be(-1);
            converter.transform_roman_numeral_to_number(string.Empty).Should().Be(-1);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_X()
        {
            converter.transform_roman_numeral_to_number("X").Should().Be(10);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_CXLVI()
        {
            converter.transform_roman_numeral_to_number("CXLVI").Should().Be(146);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_CDXCIV()
        {
            converter.transform_roman_numeral_to_number("CDXCIV").Should().Be(494);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_MMXVIII()
        {
            converter.transform_roman_numeral_to_number("MMXVIII").Should().Be(2018);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_x()
        {
            converter.transform_roman_numeral_to_number("x").Should().Be(10);
        }

        [Test]
        public void transform_roman_numeral_to_number_should_return_10_for_cdxciv()
        {
            converter.transform_roman_numeral_to_number("cdxciv").Should().Be(494);
        }
    }
}
