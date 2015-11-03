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
			Console.WriteLine ("Silnia z 10 wg. wikipedii wynosi 3628800, natomiast wg. naszego programu {0}",result1);

			Task2 task2 = new Task2 ();
			var result2 = task2.IsPrimeNumber(3);

			Console.WriteLine ("Czy liczba 3 jest liczbą pierwszą? {0}", result2);
		}
	}
}
