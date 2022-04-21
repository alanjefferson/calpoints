
using NUnit.Framework;

namespace CalPoints.nUnitTests
{
	public class SolutionTests
	{
		private Solution _solution { get; set; } = null!;

		[SetUp]
		public void Setup()
		{
			_solution = new Solution();
		}

		[Test]
		public void CalPoints_Test1()
		{
			string[] ops = { "5", "2", "C", "D", "+" };
			int output = _solution.CalPoints(ops);
			Assert.AreEqual(30, output);
		}

		[Test]
		public void CalPoints_Test2()
		{
			string[] ops = { "5", "-2", "4", "C", "D", "9", "+", "+" };
			int output = _solution.CalPoints(ops);
			Assert.AreEqual(27, output);
		}

		[Test]
		public void CalPoints_Test3()
		{
			string[] ops = { "1" };
			int output = _solution.CalPoints(ops);
			Assert.AreEqual(1, output);
		}
	}
}