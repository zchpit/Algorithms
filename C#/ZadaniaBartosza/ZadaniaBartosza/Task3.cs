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
			int smaller = x > y ? y : x;

			for (int i = smaller; i > 0; i--) {
				int restX = x % i;
				int restY = y % i;

				if (restX == 0 && restY == 0)
					return -1 * i;
			}
			return dontExists;
		}
	}
}

