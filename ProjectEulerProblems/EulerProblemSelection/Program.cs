using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EulerProblems;

namespace EulerProblemSelection
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			int inputNum = 0;
			string output = string.Empty;

			Console.WriteLine("Please enter the Problem number you would like to Run: ");
			input = Console.ReadLine();

			Console.Clear();

			if (int.TryParse(input, out inputNum))
			{
				Console.WriteLine("Problem " + input + "\r\n");
				switch (inputNum)
				{
					case 1:
						Problem1 pr1 = new Problem1();
						output = pr1.SumMultiplesOfThreeAndFive().ToString();
						break;
					case 2:
						Problem2 pr2 = new Problem2();
						output = pr2.EvenFibonacciSum().ToString();
						break;
					case 3:
						Problem3 pr3 = new Problem3();
						output = pr3.FindLargestPrimeFactor().ToString();
						break;
					case 4:
						Problem4 pr4 = new Problem4();
						output = pr4.LargestPalindrome().ToString();
						break;
					case 5:
						Problem5 pr5 = new Problem5();
						output = pr5.FindSmallestMultiple().ToString();
						break;
					case 6:
						Problem6 pr6 = new Problem6();
						output = pr6.SumSquareDifference().ToString();
						break;
					case 7:
						output = "Not yet Implemented";
						break;
					case 8:
						output = "Not yet Implemented";
						break;
					case 9:
						output = "Not yet Implemented";
						break;
					case 10:
						output = "Not yet Implemented";
						break;
					case 11:
						output = "Not yet Implemented";
						break;
					case 12:
						output = "Not yet Implemented";
						break;
					case 13:
						output = "Not yet Implemented";
						break;
					default:
						output = "Problem Number Not Found!";
						break;
				}
			}
			else
			{
				output = "Invalid Input";
			}
			Console.WriteLine(output);
			Console.Read();
			
			
		}
	}
}
