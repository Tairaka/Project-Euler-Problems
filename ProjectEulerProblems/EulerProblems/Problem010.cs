using System;

using Utils;

namespace EulerProblems
{
	public class Problem010
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=10
		//
		// Problem 10
		// Summation of Primes
		//
		// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17
		//
		// Find the sum of all the primes below two million.
		//
		//**************************************************************************

		public long SummationOfPrimes(int limit = 2000000)
		{
			long sum = 0;

			for(int i = 0; i < limit+1; i++)
			{
				if(Utilities.IsPrime(i))
				{
					sum += i;
				}
			}
			Console.WriteLine();
			return sum;
		}
	}
}
