
using Moq;
using NETCommunity.FsCheck.Discounts;
using NETCommunity.FsCheck.Discounts.Card;

namespace NETCommunity.FsCheck.Tests.Discounts.Card
{
	
	public class DiscountCardDiscountTests
	{
		private MockRepository mockRepository;

		private Mock<IDiscountCard> mockDiscountCard;

		[TestInitialize]
		public void TestInitialize()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);

			this.mockDiscountCard = this.mockRepository.Create<IDiscountCard>();
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
			DiscountCardDiscount discountCardDiscount = this.CreateDiscountCardDiscount();


			// Assert

		}

		private DiscountCardDiscount CreateDiscountCardDiscount()
		{
			return new DiscountCardDiscount(
				this.mockDiscountCard.Object);
		}
	}
}
