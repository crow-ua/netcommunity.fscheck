using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Payment
{
	// "3/7 net 30 extra 10"
	// the buyer must pay within 30 days of the invoice date, but will receive a 3% discount if they pay within 7 days after the end of the month indicated 
	// on the invoice date plus an extra 10 days.
	public class ThreeSevenNetThirtyExtraTenSeasonalDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.97m;
	    }
    }
}