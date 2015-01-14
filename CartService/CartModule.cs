using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace CartService
{
	public class CartModule : NancyModule
	{
		private readonly ICartRepository _cartRepository;

		public CartModule(ICartRepository cartRepository):base("/cart")
		{
			_cartRepository = cartRepository;
			Get["/{id}"] = x => _cartRepository.GetCartById(x.id);
		}
	}
}