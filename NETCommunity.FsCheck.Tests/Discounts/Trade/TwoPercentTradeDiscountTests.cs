
using Moq;
using NETCommunity.FsCheck.Discounts.Trade;

namespace NETCommunity.FsCheck.Tests.Discounts.Trade
{
	
	public class TwoPercentTradeDiscountTests
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
			TwoPercentTradeDiscount twoPercentTradeDiscount = this.CreateTwoPercentTradeDiscount();


			// Assert

		}

		private TwoPercentTradeDiscount CreateTwoPercentTradeDiscount()
		{
			return new TwoPercentTradeDiscount();
		}
	}
}
