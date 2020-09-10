using AutoFixture;
using AutoFixture.Xunit2;
using dotnet_workshop_tdd;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace dotnet_workshop_tdd_tests
{
	public class StringCalculatorTests
	{
		private static readonly Fixture _fixture = new Fixture();

		[Theory]
		[AutoData]
		public void Add_WithTwoNumbers_ReturnTheSumOfTheNumbers(int numberA, int numberB)
		{
			// ARRANGE
			var numbers = $"{numberA}, {numberB}";

			// System Under Test
			var sut = new StringCalculator();

			// ACT
			var actual = sut.Add(numbers);

			// ASSERT
			Assert.Equal(numberA + numberB, actual);
		}

		[Theory]
		[AutoData]
		public void Add_WithSingleNumber_ReturnTheNumber(int number)
		{
			// System Under Test
			var sut = new StringCalculator();

			var actual = sut.Add(number.ToString());

			Assert.Equal(number, actual);
		}

		[Fact]
		public void Add_NumbersIsEmpty_ReturnZero()
		{
			// System Under Test
			var sut = new StringCalculator();

			var actual = sut.Add(string.Empty);

			Assert.Equal(0, actual);
		}

		[Fact]
		public void Add_NumbersIsNull_ThrowNullArgException()
		{
			// System Under Test
			var sut = new StringCalculator();

			Assert.Throws<ArgumentNullException>(() => sut.Add(null));
		}
	}
}
