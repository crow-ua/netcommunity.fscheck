using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic
{
	// 6% discount to customers with what is considered to be a disability.
	public class SixPercentDiscountForCustomerWithDisability : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.94m;
	    }
    }
}