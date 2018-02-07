
using Moq;
using NETCommunity.FsCheck.Discounts.Offers;

namespace NETCommunity.FsCheck.Tests.Discounts.Offers
{
	
	public class FreeGiftTests
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
			FreeGift freeGift = this.CreateFreeGift();


			// Assert

		}

		private FreeGift CreateFreeGift()
		{
			return new FreeGift();
		}
	}
}
