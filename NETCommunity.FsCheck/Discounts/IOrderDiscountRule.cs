using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts
{
    public interface IOrderDiscountRule : IDiscountRule
	{
	    decimal Apply(ICart cart);
    }
}