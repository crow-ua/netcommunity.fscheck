using System.Collections.Generic;

namespace NETCommunity.FsCheck.Cart
{
	public interface ICart
	{
		List<ICartLineItem> CartItems { get; set; }
		decimal GrandTotal { get; set; }
	}
}