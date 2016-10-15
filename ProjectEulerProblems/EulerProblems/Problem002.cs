﻿namespace EulerProblems
{
	public class Problem002
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=2
		//
		// Problem 2
		// Even Fibonacci numbers
		//
		// Each new term in the Fibonacci sequence is generated by addin the previous
		// two terms. By starting with 1 and 2, the first 10 terms will be:
		//
		//		1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
		//
		// By considering the terms in the Fibonacci sequence whose values do not
		// exceed four million, find the sum of the even-valued terms.
		//
		//**************************************************************************

		public int EvenFibonacciSum(int upperLimit = 4000000)
		{
			int firstNum = 1;
			int secondNum = 2;
			int tempNum = 0;

			int sum = 2;

			while (firstNum + secondNum < upperLimit)
			{
				tempNum = firstNum + secondNum;

				if (tempNum % 2 == 0)
				{
					sum += tempNum;
				}

				if (firstNum > secondNum)
				{
					secondNum = tempNum;
				}
				else if (firstNum < secondNum)
				{
					firstNum = tempNum;
				}
			}

			return sum;
		}
	}
}
