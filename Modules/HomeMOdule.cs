using Nancy;
using System.Collections.Generic;
using QueenAttack.Objects;

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
			Post["/result"] = _ =>
			{
				int queenX = int.Parse(Request.Form["queenX"]);
				int queenY = int.Parse(Request.Form["queenY"]);
				int targetX = int.Parse(Request.Form["targetX"]);
				int targetY = int.Parse(Request.Form["targetY"]);
				Queen newQueen = new Queen(queenX, queenY);
				return View["result.cshtml", newQueen.CanTakePiece(targetX, targetY)];
			};
		}
	}
}
