using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic.Age
{
	// 5% discount for kids.
	public class FivePercentKidsDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.95m;
	    }
    }
}