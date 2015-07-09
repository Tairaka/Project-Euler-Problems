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
		// Created this vairable instead of using a default value for problem8
		// to help keep the method signature cleaner
		private static string testSeries = "73167176531330624919225119674426574742355349194934" +
										   "96983520312774506326239578318016984801869478851843" +
										   "85861560789112949495459501737958331952853208805511" +
										   "12540698747158523863050715693290963295227443043557" +
										   "66896648950445244523161731856403098711121722383113" +
										   "62229893423380308135336276614282806444486645238749" +
										   "30358907296290491560440772390713810515859307960866" +
										   "70172427121883998797908792274921901699720888093776" +
										   "65727333001053367881220235421809751254540594752243" +
										   "52584907711670556013604839586446706324415722155397" +
										   "53697817977846174064955149290862569321978468622482" +
										   "83972241375657056057490261407972968652414535100474" +
										   "82166370484403199890008895243450658541227588666881" +
										   "16427171479924442928230863465674813919123162824586" +
										   "17866458359124566529476545682848912883142607690042" +
										   "24219022671055626321111109370544217506941658960408" +
										   "07198403850962455444362981230987879927244284909188" +
										   "84580156166097919133875499200524063689912560717606" +
										   "05886116467109405077541002256983155200055935729725" +
										   "71636269561882670428252483600823257530420752963450";
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
						Problem7 pr7 = new Problem7();
						output = pr7.nthPrimeNumber().ToString();
						break;
					case 8:
						Problem8 pr8 = new Problem8();
						output = pr8.LargestProductInSeries(testSeries).ToString();
						break;
					case 9:
						Problem9 pr9 = new Problem9();
						output = pr9.SpecialPythagoreanTriplet().ToString();
						break;
					case 10:
						Problem10 pr10 = new Problem10();
						output = pr10.SummationOfPrimes().ToString();
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
