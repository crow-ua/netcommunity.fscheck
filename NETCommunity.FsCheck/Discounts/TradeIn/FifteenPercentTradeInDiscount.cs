using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.TradeIn
{
	// Fifteen percent trade-in discount.
	public class FifteenPercentTradeInDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.98m;
	    }
    }
}