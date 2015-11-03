using System;
using NUnit.Framework;

namespace ZadaniaBartosza
{
	[TestFixture]
	public class Task1Tests
	{
		public Task1Tests ()
		{
		}
		[Test]
		public void FactorialTests()
		{
			Task1 task1 = new Task1();

			//results taken from https://pl.wikipedia.org/wiki/Silnia
			Assert.AreEqual(1, task1.Factorial (0));
			Assert.AreEqual(1, task1.Factorial (1));
			Assert.AreEqual(2, task1.Factorial (2));
			Assert.AreEqual(6, task1.Factorial (3));
			Assert.AreEqual(24, task1.Factorial (4));
			Assert.AreEqual(120, task1.Factorial (5));
			Assert.AreEqual(720, task1.Factorial (6));
			Assert.AreEqual(5040, task1.Factorial (7));
			Assert.AreEqual(40320, task1.Factorial (8));
			Assert.AreEqual(362880, task1.Factorial (9));
			Assert.AreEqual(3628800, task1.Factorial (10));
		}
	}
}

