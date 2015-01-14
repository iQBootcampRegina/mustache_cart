using System;

namespace CartService
{
	public interface ICartRepository
	{
		Cart GetCartById(Guid id);
	}
}