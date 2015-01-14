using System;
using System.Collections.Generic;
using System.Linq;

namespace CartService
{
	public class InMemoryCartRepository : ICartRepository
	{
		IList<Cart> _carts; 

		public InMemoryCartRepository()
		{
			_carts = new List<Cart>();
			_carts.Add(new Cart
				{
					Id = Guid.NewGuid(),
					Address = new Address {Name = "Homer Simpson", City = "Springfield", PostalCode = "A8A8A8"},
					Items =
						new List<CartItem>
							{
								new CartItem {ProductId = 1, Description = "some product", Quantity = 2, Price = 2.99m},
								new CartItem {ProductId = 2, Description = "some product2", Quantity = 3, Price = 19.99m}
							},
					LastModified = DateTimeOffset.UtcNow,
					State = CartState.InProgress
				});
		}
		public Cart GetCartById(Guid id)
		{
			return _carts.SingleOrDefault(c => c.Id == id);
		}

		public Cart CreateCart(Cart cart)
		{
			//Validations and such
			cart.Id = Guid.NewGuid();
			_carts.Add(cart);
			return cart;
		}

		public CartItem AddItem(Guid cartId, CartItem item)
		{
			var cart =_carts.Single(c => c.Id == cartId);
			var items = cart.Items.ToList();
			items.Add(item);
			cart.Items = items;

			return item;
		}

		public CartItem UpdateItem(Guid cartId, CartItem item)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Cart> GetCarts()
		{
			return _carts;
		}
	}
}