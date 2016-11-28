using System.Collections.Generic;
using System;

namespace QueenAttack.Objects
{
	public class Queen
	{
		private int _queenX = 3;
		private int _queenY = 3;

		public void SetX(int x)
		{
			_queenX = x;
		}

		public void SetY(int y)
		{
			_queenY = y;
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
