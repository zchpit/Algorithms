using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadaniaBartosza
{
	public class Task5
	{
		public static List<int> GetRandomSortList()
		{
			Random r = new Random();
			List<int> list = new List<int> (20){};
			for (int i = 0; i < 20; i++) {
				list.Add(r.Next(1, 20));
			}
			list = list.OrderBy (a => a).ToList();
			return list;
		}
	}
}

