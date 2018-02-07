using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Payment
{
	// "3/7 EOM"
	// the buyer will receive a cash discount of 3% if the bill is paid within 7 days after the end of the month indicated on the invoice date. 
	// If an invoice is received on or before the 25th day of the month, payment is due on the 7th day of the next calendar month. 
	// If a proper invoice is received after the 25th day of the month, payment is due on the 7th day of the second calendar month.
	public class ThreeSevenEOMPromptPayment : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.97m;
	    }
    }
}