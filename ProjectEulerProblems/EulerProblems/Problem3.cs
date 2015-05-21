using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utils;

namespace EulerProblems
{
	public class Problem3
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=3
		//
		// Problem 3
		// Largest Prime Factor
		//
		// The Prime factors of 13195 are 5, 7, 13 and 29.
		//
		// What is the largest prime factor of the number 600851475143 ?
		//
		//**************************************************************************

		private long tempNum, largestNum = 0;

		public long FindLargestPrimeFactor(long inputNum = 600851475143)
		{
			tempNum = inputNum;
			for (long i = 1; i < tempNum; i++)
			{
				if(tempNum % i == 0)
				{
					if(Utilities.IsPrime(i))
					{
						if(i > largestNum)
						{
							largestNum = i;
						}
						tempNum = inputNum / i;
					}
				}
			}
			return largestNum;

		}
	}
}
