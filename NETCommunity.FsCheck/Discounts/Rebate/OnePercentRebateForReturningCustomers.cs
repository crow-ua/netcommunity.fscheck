using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Rebate
{
	// 1% rebate for returning customers.
	public class OnePercentRebateForReturningCustomers : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.99m;
	    }
    }
}