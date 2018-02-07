
using Moq;
using NETCommunity.FsCheck.Discounts.TradeIn;

namespace NETCommunity.FsCheck.Tests.Discounts.TradeIn
{
	
	public class FifteenPercentTradeInDiscountTests
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
			FifteenPercentTradeInDiscount fifteenPercentTradeInDiscount = this.CreateFifteenPercentTradeInDiscount();


			// Assert

		}

		private FifteenPercentTradeInDiscount CreateFifteenPercentTradeInDiscount()
		{
			return new FifteenPercentTradeInDiscount();
		}
	}
}
