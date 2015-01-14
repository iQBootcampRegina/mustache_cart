using System;
using System.Collections.Generic;

namespace CartService
{
	public interface ICartRepository
	{
		Cart GetCartById(Guid id);
		Cart CreateCart(Cart cart);
		CartItem AddItem(Guid cartId, CartItem item);
		CartItem UpdateItem(Guid cartId, CartItem item);

		IEnumerable<Cart> GetCarts();
	}
}