
using Moq;
using NETCommunity.FsCheck.Discounts.Bulk;

namespace NETCommunity.FsCheck.Tests.Discounts.Bulk
{
	
	public class TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscountTests
	{
	    public readonly MockRepository MockRepository;

	    public TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscountTests(MockRepository mockRepository)
	    {
	        MockRepository = mockRepository;
	    }

	    [TestInitialize]
		public void TestInitialize()
		{
			
		}

		[TestCleanup]
		public void TestCleanup()
		{
			MockRepository.VerifyAll();
		}

		[TestMethod]
		public void TenItemsPurchasedLastMonth_DiscountApplied()
		{
			// Arrange
			var target = CreateTenPercentForTenItemsPurchasedDuringLastMonthCumulativeQuantityDiscount();

			// Act



			// Assert

		}

		private TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscount CreateTenPercentForTenItemsPurchasedDuringLastMonthCumulativeQuantityDiscount()
		{
			return new TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscount();
		}
	}
}