using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Coupon
{
	// Discount for customer with christmas promotion coupon.
	public class ChristmasPromotionCouponDiscount
	{
		private readonly ICoupon _coupon;

		public ChristmasPromotionCouponDiscount(ICoupon coupon)
		{
			_coupon = coupon;
		}
		public decimal Apply(ICartLineItem cartLineItem)
		{
			return cartLineItem.Quantity * cartLineItem.Price * _coupon.Discount;
		}
	}
}