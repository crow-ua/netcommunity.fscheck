using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Payment
{
	// "3/7 EOM net 30"
	// the buyer must pay within 30 days of the invoice date, but will receive a 3% discount if they pay 
	// within 7 days after the end of the month indicated on the invoice date. 
	// If an invoice is received on or before the 25th day of the month, payment is due on the 7th day of the next calendar month. 
	// If a proper invoice is received after the 25th day of the month, payment is due on the 7th day of the second calendar month.
	public class ThreeSevenEOMNetThirtyPromptPayment : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.97m;
	    }
    }
}