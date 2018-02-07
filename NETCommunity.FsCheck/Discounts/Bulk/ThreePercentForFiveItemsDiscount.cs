using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Bulk
{
	// 3% for five items purchase non-cumulative quantity discount.
	public class ThreePercentForFiveItemsDiscount : IItemDiscountRule
    {
	    public decimal Apply(ICartLineItem cartLineItem)
	    {
		    return cartLineItem.Quantity * cartLineItem.Price * 0.97m;
	    }
    }
}