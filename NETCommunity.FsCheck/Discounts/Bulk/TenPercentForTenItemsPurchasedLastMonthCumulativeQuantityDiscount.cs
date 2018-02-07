using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Bulk
{
	// 10% discount for 10 items purchased during last month.
	public class TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscount : IItemDiscountRule
    {
	    public decimal Apply(ICartLineItem cartLineItem)
	    {
		    return cartLineItem.Quantity * cartLineItem.Price * 0.9m;
	    }
    }
}