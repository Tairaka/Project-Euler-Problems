using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
	public class Problem005
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=5
		//
		// Problem 5
		// Smallest Multiple
		//
		// 2520 is the smallest number that can be divided by each of the numbers
		// from 1 to 10 without any remainder.
		//
		// What is the smallest positive number that is evenly divisible by all of
		// the numbers from 1 to 20?
		//
		//**************************************************************************

		public long FindSmallestMultiple(int largestFactor = 20)
		{
			bool isFinished = false;
			long myNum = 1;

			while(!isFinished)
			{
				for (int i = 1; i <= largestFactor; i++)
				{
					if (myNum % i == 0)
					{
						if(i == largestFactor)
						{
							isFinished = true;
							break;
						}
					}
					else
					{
						myNum++;
						break;
					}
				}
			}
			return myNum;
		}
	}
}
