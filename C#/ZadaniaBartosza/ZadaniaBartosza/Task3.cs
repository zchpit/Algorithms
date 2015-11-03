using System;

namespace ZadaniaBartosza
{
	public class Task3
	{
		public Task3 ()
		{
			
		}
		public int GetSmallestCommonDivisor(int x, int y)
		{
			int dontExists = -1;

			for (int i = 2; i < Int32.MaxValue; i++) {
				int restX = x % i;
				int restY = y % i;

				if (restX == 0 && restY == 0)
					return i;
				if (i > x || i > y)
					return dontExists;
			}
			return dontExists;
		}
	}
}

