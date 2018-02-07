using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Trade
{
	// 2% discount off the retail price
	public class TwoPercentTradeDiscount : IItemDiscountRule
    {
	    public decimal Apply(ICartLineItem cartLineItem)
	    {
		    return cartLineItem.Quantity * cartLineItem.Price * 0.98m;
	    }
    }
}