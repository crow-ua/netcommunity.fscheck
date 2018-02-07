
using Moq;
using NETCommunity.FsCheck.Discounts.Offers;

namespace NETCommunity.FsCheck.Tests.Discounts.Offers
{
	
	public class FreeShippingTests
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
			FreeShipping freeShipping = this.CreateFreeShipping();


			// Assert

		}

		private FreeShipping CreateFreeShipping()
		{
			return new FreeShipping();
		}
	}
}
