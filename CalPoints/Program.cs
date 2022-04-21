using System;

namespace CalPoints {
	class CallPoints {
		public static void Main(string[] args) {
			var solution = new Solution();
			var space = new char[] { ' ' };

			string[] ops = (Console.ReadLine() ?? String.Empty).Split(space);
			int output = solution.CalPoints(ops);
			Console.WriteLine(output.ToString());
		}
	}
}