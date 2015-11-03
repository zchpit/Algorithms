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

			var result = task1.Factorial (10);
			Console.WriteLine ("Silnia z 10 wg. wikipedii wynosi 3628800, natomiast wg. naszego programu {0}",result);
		}
	}
}
