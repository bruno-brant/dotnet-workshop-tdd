using System;
using System.Linq;

namespace dotnet_workshop_tdd
{
	public class StringCalculator
	{
		public int Add(string numbers)
		{
			if (numbers is null)
			{
				throw new ArgumentNullException(nameof(numbers));
			}

			var splitted = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries);

			var numbersAsInt = splitted.Select(_ => int.Parse(_));

			return numbersAsInt.Sum();
		}
	}
}
