using System;

namespace ZadaniaBartosza
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("ZadaniaBartosza from wykop.pl http://www.wykop.pl/tag/zadaniabartosza/");

			//task 1 example (more in unit tests)
			Task1 task1 = new Task1();
			var result1 = task1.Factorial (10);

			Task2 task2 = new Task2 ();
			var result2 = task2.IsPrimeNumber(3);

			Task3 task3 = new Task3 ();
			task3.GetSmallestCommonDivisor (2, 4);

			Task4 task4 = new Task4 ();
			var a = Math.Pow (3, 5);
			var b = task4.Power (3, 5);
			var c = task4.Power (3, -3);

			var randomSortList = Task5.GetRandomSortList ();
			foreach (var random in randomSortList) {
				Console.WriteLine (random);
			}

			Task6 task61 = new Task6 ();
			Task6 task62 = new Task6 ();
			Task6 task63 = new Task6 ();

			bool areEqual = false;
			if (task61.PositionX == task62.PositionX && task62.PositionX == task63.PositionX &&
				task61.PositionY == task62.PositionY && task62.PositionY == task63.PositionY) {
				areEqual = true;
			}
			Console.ReadKey ();
		}
	}
}
