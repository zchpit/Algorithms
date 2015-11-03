using System;

namespace ZadaniaBartosza
{
	/*
    Napisz program, który obliczy oraz wyświetli !N (silnię) wybranej przez siebie liczby.
	*/
	public class Task1
	{
		public Task1 ()
		{
		}
		public int Factorial(int input)
		{
			if(input <= 1)
				return 1;

			return input * Factorial (input-1);
		}
	}
}

