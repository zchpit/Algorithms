using System;
using NUnit.Framework;

namespace ZadaniaBartosza
{
	[TestFixture]
	public class Task4Tests
	{
		public Task4Tests ()
		{
			
		}
		[Test]
		public void PowerTests()
		{
			Task4 task = new Task4();

			Assert.AreEqual(Math.Pow (2, 4),  task.Power(2,4));
			Assert.AreEqual(Math.Pow (3, 9),  task.Power(3,9));
			Assert.AreEqual(Math.Pow (2, 8),  task.Power(2,8));
			Assert.AreEqual(Math.Pow (3, 8),  task.Power(3,8));
			Assert.AreEqual(Math.Pow (1, 1),  task.Power(1,1));
			Assert.AreEqual(Math.Pow (0, 1),  task.Power(0,1));
			Assert.AreEqual(Math.Pow (1, 0),  task.Power(1,0));
			Assert.AreEqual(Math.Pow (-3, 3),  task.Power(-3,3));
			Assert.AreEqual(Math.Pow (-1, 2),  task.Power(-1,2));
			Assert.AreEqual(Math.Pow (2, -2),  task.Power(2,-2));
			Assert.AreEqual(Math.Pow (3, -4),  task.Power(3,-4));
			Assert.AreEqual(Math.Pow (-3, -4),  task.Power(-3,-4));
		}
	}
}