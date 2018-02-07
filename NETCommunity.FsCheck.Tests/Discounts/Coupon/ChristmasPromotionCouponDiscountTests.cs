
using Moq;
using NETCommunity.FsCheck.Discounts;
using NETCommunity.FsCheck.Discounts.Coupon;

namespace NETCommunity.FsCheck.Tests.Discounts.Coupon
{
	
	public class ChristmasPromotionCouponDiscountTests
	{
		private MockRepository mockRepository;

		private Mock<ICoupon> mockCoupon;

		[TestInitialize]
		public void TestInitialize()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockCoupon = this.mockRepository.Create<ICoupon>();
		}

		[TestCleanup]
		public void TestCleanup()
		{
			this.mockRepository.VerifyAll();
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange


			// Act
			ChristmasPromotionCouponDiscount christmasPromotionCouponDiscount = this.CreateChristmasPromotionCouponDiscount();


			// Assert

		}

		private ChristmasPromotionCouponDiscount CreateChristmasPromotionCouponDiscount()
		{
			return new ChristmasPromotionCouponDiscount(
				this.mockCoupon.Object);
		}
	}
}
