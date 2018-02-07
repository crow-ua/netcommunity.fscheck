namespace NETCommunity.FsCheck.Cart
{
	public interface ICartLineItem
	{
		string Name { get; set; }
		int Quantity { get; set; }
		decimal Price { get; set; }
	}
}