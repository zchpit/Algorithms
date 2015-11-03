using System;
using NUnit.Framework;

namespace ZadaniaBartosza
{
	[TestFixture]
	public class Task3Tests
	{
		Task3 task;
		public Task3Tests ()
		{
			task = new Task3();
		}
		[Test]
		public void CommonDivisorExists()
		{
			Assert.AreEqual(2,  task.GetSmallestCommonDivisor(2,4));
			Assert.AreEqual(3,  task.GetSmallestCommonDivisor(3,9));
			Assert.AreEqual(2,  task.GetSmallestCommonDivisor(2,8));
			Assert.AreEqual(2,  task.GetSmallestCommonDivisor(4,16));
			Assert.AreEqual(3,  task.GetSmallestCommonDivisor(9,18));
			Assert.AreEqual(17,  task.GetSmallestCommonDivisor(17,34));
		}
		[Test]
		public void CommonDivisorDontExists()
		{
			Assert.AreEqual(-1,  task.GetSmallestCommonDivisor(3,5));
			Assert.AreEqual(-1,  task.GetSmallestCommonDivisor(5,3));
			Assert.AreEqual(-1,  task.GetSmallestCommonDivisor(15,4));
		}
	}
}

