using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
	public class Problem6
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=5
		//
		// Problem 
		// Sum Square Difference
		//
		// The sum of the squares of the first ten natural numbers is,
		// 1^2 + 2^2 + ... + 10^2 = 385
		// 
		// The square of the sum of the first ten natural numbers is,
		// (1 + 2 + ... + 10)^2 = 552 = 3025
		//
		// Hence the difference between the sum of squares of the first ten natural
		// numbers and the square of the sum is 3025 - 385 = 2640.
		//
		// Find the difference between the sum of the squares of the first one
		// hundred natural numbers and the square of the sum.
		//**************************************************************************


		public long SumSquareDifference(int numOfNums = 100)
		{
			long sumOfSquares = 0;
			long squareOfSums = 0;
			long difference = 0;

			for(int i = 1; i < numOfNums + 1; i++)
			{
				sumOfSquares += i * i;
				squareOfSums += i;
			}
			squareOfSums = squareOfSums * squareOfSums;

			difference = squareOfSums - sumOfSquares;

			return difference;
		}


	}
}
