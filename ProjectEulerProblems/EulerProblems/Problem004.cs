using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
	public class Problem004
	{
		//**************************************************************************
		// The following problem can be found here:
		//	https://projecteuler.net/problem=4
		//
		// Problem 4
		// Largest Palindrome Product
		//
		// A palindromic number reads the same both ways. The largest palindrome
		// made from the product pf two 2-digit numbers is 9009 = 91 * 99.
		//
		// Find the largest palindrome made from the product of two 3-digit numbers.
		//
		//**************************************************************************

		private int num1, num2, tempNum, largestNum = 0;

		public int LargestPalindrome(int numDigits = 3)
		{
			string startNum = string.Empty;

			for(int i = 0; i < numDigits; i++)
			{
				startNum +="9";
			}

			int.TryParse(startNum, out num1);
			num2 = num1;

			for(int i = num1; i >= 100; i--)
			{
				for(int j = num2; j >= 100; j--)
				{ 
					tempNum = i * j;
					if(IsNumberPalindrome(tempNum))
					{
						if(tempNum > largestNum)
						{
							largestNum = tempNum;
						}
					}
				}
			}
			return largestNum;

		}

		public bool IsNumberPalindrome(int testNum)
		{
			char[] charArray = testNum.ToString().ToCharArray();

			bool result = false;
			for (int i = 0; i < (charArray.Length / 2); i++)
			{
				if (charArray[i] == charArray[charArray.Length - (i + 1)])
				{
					result = true;
				}
				else
				{
					result = false;
					break;
				}
			}
			return result;
		}
	}
}
