using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.CustomerCharacteristic
{
	// 5% discount to students.
	public class FivePercentDiscountToStudents : IOrderDiscountRule
    {
	    public decimal Apply(ICart cart)
	    {
		    return cart.GrandTotal * 0.95m;
	    }
    }
}