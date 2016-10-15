using System;

namespace EulerProblems
{
	public class Problem009
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=9
		//
		// Problem 9
		// Special Pythagorean Triplet
		//
		// A Pythagorean Triplet is a set of three natural numbers, a < b < c, for
		// which,
		// a^2 + b^2 = c^2
		//
		// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
		//
		// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
		// Find the product abc.
		//
		//**************************************************************************

		public long SpecialPythagoreanTriplet()
		{
			long product = 0;

			for (int a = 0; a < 1000; a++)
			{
				for (int b = 0; b < 1000; b++)
				{
					for (int c = 0; c < 1000; c++)
					{
						if ((a + b + c) == 1000 && a < b && b < c)
						{
							if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
							{
								product = a * b * c;
								break;
							}
						}
					}
				}
			}
			return product;
		}
	}
}
