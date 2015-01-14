using System;
using System.Collections.Generic;

namespace CartService
{
	public class InMemoryCartRepository : ICartRepository
	{
		public Cart GetCartById(Guid id)
		{
			return new Cart
				{
					Address = new Address {Name = "Homer Simpson", City = "Springfield", PostalCode = "A8A8A8"},
					Items =
						new List<CartItem>
							{
								new CartItem {ProductId = 1, Description = "some product", Quantity = 2, Price = 2.99m},
								new CartItem {ProductId = 2, Description = "some product2", Quantity = 3, Price = 19.99m}
							},
					LastModified = DateTimeOffset.UtcNow,
					State = CartState.InProgress
				};
		}
	}
}