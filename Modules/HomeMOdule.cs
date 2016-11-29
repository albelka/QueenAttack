using Nancy;
using System.Collections.Generic;
using QueenAttack.Objects;
using System;

namespace QueenAttack
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
			Post["/target"] = _ =>
			{
				string queenString = Request.Form["clicked"];
				// int queenX = Convert.ToInt32(queenString[1]);
				// int queenY = Convert.ToInt32(queenString[0]);
				Queen newQueen = new Queen(0, 0);
				List<Queen> allQueens = Queen.GetAll();
				return View["target.cshtml", allQueens[0]];
			};
			Post["/result"] = _ =>
			{
				string targetString = Request.Form["target"];
				int targetX = int.Parse(targetString[1].ToString());
				int targetY = int.Parse(targetString[0].ToString());
				List<Queen> allQueens = Queen.GetAll();
				return View["result.cshtml", allQueens[0].CanTakePiece(targetX, targetY)];
			};
		}
	}
}
