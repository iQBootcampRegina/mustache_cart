﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace CartService
{
	public class CartModule : NancyModule
	{
		private readonly ICartRepository _cartRepository;

		public CartModule(ICartRepository cartRepository):base("/carts")
		{
			_cartRepository = cartRepository;

			Get["/"] = x => _cartRepository.GetCarts();
			Get["/RESET"] = x => ResetCarts();
			Get["/{id}"] = x => _cartRepository.GetCartById(x.id);
			Post["/{id}/Items"] = x => _cartRepository.AddItem(x.id, this.Bind<CartItem>());
			Put["/{id}/Items/{itemId}"] = x => _cartRepository.UpdateItem(x.id, x.itemId, this.Bind<CartItem>());
		    Delete["/{id}/Items/{itemId}"] = x => _cartRepository.DeleteItem(x.id, x.itemId);
			Post["/"] = x => CreateCart();
		}

		private Cart CreateCart()
		{
			var cart = this.Bind<Cart>();
			return _cartRepository.CreateCart(cart);
		}

		private IEnumerable<Cart> ResetCarts()
		{
			_cartRepository.ResetCartsList();
			return _cartRepository.GetCarts();
		}
	}
}