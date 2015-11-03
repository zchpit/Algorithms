using System;
using NUnit.Framework;

namespace ZadaniaBartosza
{
	[TestFixture]
	public class Task2Tests
	{
		Task2 task;
		public Task2Tests ()
		{
			task = new Task2();
		}
		[Test]
		public void PrimeNumbers()
		{
			//results taken from https://pl.wikipedia.org/wiki/Silnia
			Assert.IsTrue(task.IsPrimeNumber (3));
			Assert.IsTrue(task.IsPrimeNumber (5));
			Assert.IsTrue(task.IsPrimeNumber (7));
			Assert.IsTrue(task.IsPrimeNumber (11));
			Assert.IsTrue(task.IsPrimeNumber (13));
			Assert.IsTrue(task.IsPrimeNumber (97));
		}
		[Test]
		public void NotPrimeNumbers()
		{
			//results taken from https://pl.wikipedia.org/wiki/Silnia
			Assert.IsFalse(task.IsPrimeNumber (0));
			Assert.IsFalse(task.IsPrimeNumber (1));
			Assert.IsFalse(task.IsPrimeNumber (2));
			Assert.IsFalse(task.IsPrimeNumber (4));
			Assert.IsFalse(task.IsPrimeNumber (8));
			Assert.IsFalse(task.IsPrimeNumber (16));
			Assert.IsFalse(task.IsPrimeNumber (110));
		}
	}
}

