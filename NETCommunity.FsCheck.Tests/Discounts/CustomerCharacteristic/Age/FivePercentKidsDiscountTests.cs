
using Moq;
using NETCommunity.FsCheck.Discounts.CustomerCharacteristic.Age;

namespace NETCommunity.FsCheck.Tests.Discounts.CustomerCharacteristic.Age
{
	
	public class FivePercentKidsDiscountTests
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
			FivePercentKidsDiscount fivePercentKidsDiscount = this.CreateFivePercentKidsDiscount();


			// Assert

		}

		private FivePercentKidsDiscount CreateFivePercentKidsDiscount()
		{
			return new FivePercentKidsDiscount();
		}
	}
}
