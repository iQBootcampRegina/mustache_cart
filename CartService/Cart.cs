using System;
using System.Collections.Generic;

namespace CartService
{
	public class Cart	
	{
		public Cart()
		{
			Items = new List<CartItem>();
		}
		
		public Guid Id { get; set; }
		public IEnumerable<CartItem> Items { get; set; }
		public Address Address { get; set; }
		public CartState State { get; set; }
		public DateTimeOffset LastModified { get; set; }
		
	}
}