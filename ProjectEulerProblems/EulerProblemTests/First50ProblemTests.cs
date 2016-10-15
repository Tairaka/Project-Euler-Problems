using Microsoft.VisualStudio.TestTools.UnitTesting;

using EulerProblems;

namespace EulerProblemTests
{
	[TestClass]
	public class First50ProblemTests
	{
		#region Problem1
		[TestMethod]
		public void Problem001Pass()
		{
			int firstUpperLimit = 10;
			int secondUpperLimit = 50;
			int thirdUpperLimit = 10000;

			Problem001 pr1 = new Problem001();

			Assert.AreEqual(23, pr1.SumMultiplesOfThreeAndFive(firstUpperLimit));
			Assert.AreEqual(543, pr1.SumMultiplesOfThreeAndFive(secondUpperLimit));
			Assert.AreEqual(23331668, pr1.SumMultiplesOfThreeAndFive(thirdUpperLimit));
			Assert.AreEqual(233168, pr1.SumMultiplesOfThreeAndFive());
		}

		[TestMethod]
		public void Problem001Fail()
		{
			int firstUpperLimit = 10;
			int secondUpperLimit = 50;
			int thirdUpperLimit = 10000;

			Problem001 pr1 = new Problem001();

			Assert.AreNotEqual(25, pr1.SumMultiplesOfThreeAndFive(firstUpperLimit));
			Assert.AreNotEqual(650, pr1.SumMultiplesOfThreeAndFive(secondUpperLimit));
			Assert.AreNotEqual(23332668, pr1.SumMultiplesOfThreeAndFive(thirdUpperLimit));
			Assert.AreNotEqual(267333, pr1.SumMultiplesOfThreeAndFive());
		}
		#endregion

		#region Problem2
		#endregion

		#region Problem3
		#endregion

		#region Problem4
		#endregion

		#region Problem5
		#endregion

		#region Problem6
		#endregion

		#region Problem7
		#endregion

		#region Problem8
		#endregion

		#region Problem9
		#endregion

		#region Problem10
		#endregion
	}
}
