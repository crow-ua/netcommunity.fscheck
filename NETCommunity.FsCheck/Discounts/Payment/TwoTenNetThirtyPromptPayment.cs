using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Payment
{
	// "2/10 net 30 discount"
	// Buyer must pay within 30 days of the invoice date, but will receive a 2% discount if they pay within 10 days of the invoice date
	public class TwoTenNetThirtyPromptPayment : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.98m;
	    }
    }
}