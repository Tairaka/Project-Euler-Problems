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
