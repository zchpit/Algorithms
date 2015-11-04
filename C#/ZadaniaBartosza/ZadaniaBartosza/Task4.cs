using System;

namespace ZadaniaBartosza
{
	public class Task4
	{
		public Task4 ()
		{
		}
		public decimal Power(int C, int n)
		{
			if(n == 1 || n == 0)
				return C;
			if (n < -1)
			{
				n = n * -1;
				return 1 / (C * Power (C, n-1));
			}

			return C * Power (C, n-1);
		}
	}
}

