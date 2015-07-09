using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utils;

namespace EulerProblems
{
	public class Problem7
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=7
		//
		// Problem 7
		// 10001st Prime
		//
		// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can
		// see that the 6th prime is 13.
		//
		// What is the 10001st prime number?
		//
		//**************************************************************************

		public long nthPrimeNumber(int num = 10001)
		{
			long prime = 0;
			int counter = 0;
			int testNum = 0;

			while (counter < num)
			{
				testNum++;

				if(Utilities.IsPrime(testNum))
				{
					prime = testNum;
					counter++;
				}
			}

			return prime;
		}
	}
}
