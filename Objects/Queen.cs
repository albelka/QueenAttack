using System.Collections.Generic;
using System;

namespace QueenAttack.Objects
{
	public class Queen
	{
		private int _queenX = 3;
		private int _queenY = 3;
		private static List<Queen> _queens = new List<Queen>{};

		public Queen(int queenX, int queenY)
		{
			_queenX = queenX;
			_queenY = queenY;
			_queens.Add(this);
		}

		public static List<Queen> GetAll()
		{
			return _queens;
		}

		public int GetX()
		{
			return _queenX;
		}

		public int GetY()
		{
			return _queenY;
		}

		public bool CanTakePiece(int x, int y)
		{
			if (_queenY == y)
			{
				return true;
			}
			else if (_queenX == x)
			{
				return true;
			}
			else if (Math.Abs(y - _queenY) == Math.Abs(x - _queenX))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
