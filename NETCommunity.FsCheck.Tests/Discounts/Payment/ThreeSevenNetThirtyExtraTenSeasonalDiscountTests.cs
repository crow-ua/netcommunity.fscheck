
using Moq;
using NETCommunity.FsCheck.Discounts.Payment;

namespace NETCommunity.FsCheck.Tests.Discounts.Payment
{
	
	public class ThreeSevenNetThirtyExtraTenSeasonalDiscountTests
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
			ThreeSevenNetThirtyExtraTenSeasonalDiscount threeSevenNetThirtyExtraTenSeasonalDiscount = this.CreateThreeSevenNetThirtyExtraTenSeasonalDiscount();


			// Assert

		}

		private ThreeSevenNetThirtyExtraTenSeasonalDiscount CreateThreeSevenNetThirtyExtraTenSeasonalDiscount()
		{
			return new ThreeSevenNetThirtyExtraTenSeasonalDiscount();
		}
	}
}
