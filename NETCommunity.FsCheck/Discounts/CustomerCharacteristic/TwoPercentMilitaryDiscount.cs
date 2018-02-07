using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic
{
	// 2% discount to customers who are or were members of a military service.
	public class TwoPercentMilitaryDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.98m;
	    }
    }
}