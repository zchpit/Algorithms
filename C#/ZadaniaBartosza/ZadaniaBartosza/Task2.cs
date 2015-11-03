using System;

namespace ZadaniaBartosza
{
	public class Task2
	{
		public Task2 ()
		{
		}
		public bool IsPrimeNumber(int input)
		{
			if(input <= 2)
				return false;

			for (int i = 2; i < input; i++) {
				int rest = input % i;
				if (rest == 0)
					return false;
			}
			return true;
		}
	}
}

