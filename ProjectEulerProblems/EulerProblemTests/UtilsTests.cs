using Microsoft.VisualStudio.TestTools.UnitTesting;

using Utils;


namespace EulerProblemTests
{
	[TestClass]
	public class UtilsTests
	{
		[TestMethod]
		public void IsPrimePass()
		{
			int[] primeArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 , 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };

			foreach(int p in primeArray)
			{
				Assert.IsTrue(Utilities.IsPrime(p), "The following number failed {0}", p);
			}
		}

		[TestMethod]
		public void IsPrimeFail()
		{
			int[] primeArray = new int[] { 4, 6, 8, 10, 12, 14, 16, 18, 20, 21, 27, 33, 44, 49, 54, 56, 63, 66, 70, 75 };

			foreach (int p in primeArray)
			{
				Assert.IsFalse(Utilities.IsPrime(p), "The following number failed {0}", p);
			}
		}
	}
}
