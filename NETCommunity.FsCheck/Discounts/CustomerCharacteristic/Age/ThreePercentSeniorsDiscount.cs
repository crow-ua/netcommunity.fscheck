using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic.Age
{
	// 3% discount to seniors.
	public class ThreePercentSeniorsDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.97m;
	    }
    }
}