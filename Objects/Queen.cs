using System.Collections.Generic;

namespace QueenAttack.Objects
{
	public class Queen
	{
		private int _queenX = 0;
		private int _queenY = 0;

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
			if(_queenY == y)
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
