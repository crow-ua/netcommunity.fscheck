using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic
{
	// 10% discount to employees.
	public class TenPercentEmployeeDiscount : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.9m;
	    }
    }
}