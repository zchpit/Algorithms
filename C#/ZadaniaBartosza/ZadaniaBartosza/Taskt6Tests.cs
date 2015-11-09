using System;
using NUnit.Framework;
using System.Drawing;

namespace ZadaniaBartosza
{
	[TestFixture]
	public class Taskt6Tests
	{
		Task6 task;
		public Taskt6Tests ()
		{
		}
		[Test]
		[TestCase(0, Result = true)]
		[TestCase(1, Result = true)]
		[TestCase(2, Result = true)]
		[TestCase(3, Result = true)]
		[TestCase(4, Result = true)]
		[TestCase(5, Result = true)]
		[TestCase(6, Result = true)]
		[TestCase(7, Result = false)]
		public bool CanGoForward(int input)
		{
			task = new Task6 (new Point (0, input));
			return task.IfCanGoForward();
		}
		[Test]
		[TestCase(0,0, Result = false)]
		[TestCase(1,1, Result = true)]
		[TestCase(2,7, Result = false)]
		[TestCase(3,6, Result = true)]
		[TestCase(4,5, Result = true)]
		[TestCase(7,3, Result = true)]
		[TestCase(6,1, Result = true)]
		[TestCase(7,7, Result = false)]
		public bool CanAttackLeft(int x, int y)
		{
			task = new Task6 (new Point (x, y));
			return task.IfCanAttackLeft();
		}
		[Test]
		[TestCase(0,0, Result = true)]
		[TestCase(1,1, Result = true)]
		[TestCase(2,7, Result = false)]
		[TestCase(7,6, Result = false)]
		[TestCase(4,5, Result = true)]
		[TestCase(5,3, Result = true)]
		[TestCase(6,1, Result = true)]
		[TestCase(7,7, Result = false)]
		public bool CanAttackRight(int x, int y)
		{
			task = new Task6 (new Point (x, y));
			return task.IfCanAttackRight();
		}
		[Test]
		public void RandomPosition()
		{
			Task6 task61 = new Task6 ();
			Task6 task62 = new Task6 ();
			Task6 task63 = new Task6 ();

			bool areEqual = false;
			if (task61.PositionX == task62.PositionX && task62.PositionX == task63.PositionX &&
				task61.PositionY == task62.PositionY && task62.PositionY == task63.PositionY) {
				areEqual = true;
			}
			Assert.IsFalse (areEqual);
		}
		[Test] 
		[TestCase(0, Result = "1")]
		[TestCase(1, Result = "2")]
		[TestCase(2, Result = "3")]
		[TestCase(6, Result = "7")]
		[TestCase(7, Result = "8")]
		public string ShowPositionX(int x)
		{
			task = new Task6 (new Point (x, 0));
			return task.PositionX;
		}
		[Test]
		[TestCase(0, Result = "A")]
		[TestCase(1, Result = "B")]
		[TestCase(2, Result = "C")]
		[TestCase(6, Result = "G")]
		[TestCase(7, Result = "H")]
		public string ShowPositionY(int y)
		{
			task = new Task6 (new Point (0, y));
			return task.PositionY;
		}
	}
}

