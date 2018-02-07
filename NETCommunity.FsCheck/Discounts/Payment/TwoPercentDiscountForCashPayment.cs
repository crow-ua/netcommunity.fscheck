using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Payment
{
	// "2% discount for paying in cash"
	// Some retailers (particularly small retailers with low margins) offer discounts to customers paying with cash, 
	// to avoid paying fees on credit card transactions.
	public class TwoPercentDiscountForCashPayment : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.98m;
	    }
    }
}