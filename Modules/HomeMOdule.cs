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
		}
	}
}
