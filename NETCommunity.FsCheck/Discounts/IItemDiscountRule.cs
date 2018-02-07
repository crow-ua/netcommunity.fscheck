using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts
{
    public interface IItemDiscountRule : IDiscountRule
	{
	    decimal Apply(ICartLineItem cartLineItem);
    }
}