using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace CartService
{
	public class CartModule : NancyModule
	{
		public CartModule()
		{
			Get["/"] = x => "HEY IT'S A CART SERVICE!! YAY!!!!!";
		}
	}
}