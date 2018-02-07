
using Moq;
using NETCommunity.FsCheck.Discounts.Bulk;

namespace NETCommunity.FsCheck.Tests.Discounts.Bulk
{
	
	public class ThreePercentForFiveItemsDiscountTests
	{
		private MockRepository mockRepository;



		[TestInitialize]
		public void TestInitialize()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);


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
			ThreePercentForFiveItemsDiscount threePercentForFiveItemsDiscount = this.CreateThreePercentForFiveItemsDiscount();


			// Assert

		}

		private ThreePercentForFiveItemsDiscount CreateThreePercentForFiveItemsDiscount()
		{
			return new ThreePercentForFiveItemsDiscount();
		}
	}
}
