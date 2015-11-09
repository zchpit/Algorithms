using System;
using System.Drawing;

namespace ZadaniaBartosza
{
	public class Task6
	{
		//private int[][] board;
		Point p;
		public string PositionX {get { return (p.X + 1).ToString(); }}
		public string PositionY {get { return ((Columns)p.Y).ToString (); }}

		public Task6 ()
		{
			Random r = new Random();
			p = new Point (r.Next (0, 7), r.Next (0, 7));
		}
		public Task6 (Point r)
		{
			p = r;
		}
		public bool IfCanGoForward()
		{
			if (p.Y == 7)
				return false;
			else
				return true;
		}
		public bool IfCanAttackLeft()
		{
			if (IfCanGoForward () && p.X > 0)
				return true;
			else
				return false;
		}
		public bool IfCanAttackRight()
		{
			if (IfCanGoForward () && p.X < 7)
				return true;
			else
				return false;
		}
	}

	public enum Columns
	{
		A = 0,
		B = 1,
		C = 2,
		D = 3,
		E = 4,
		F = 5,
		G = 6,
	    H = 7
	}
}

