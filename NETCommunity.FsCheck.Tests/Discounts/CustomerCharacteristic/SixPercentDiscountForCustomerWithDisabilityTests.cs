
using Moq;
using NETCommunity.FsCheck.Discounts.CustomerCharacteristic;

namespace NETCommunity.FsCheck.Tests.Discounts.CustomerCharacteristic
{
	
	public class SixPercentDiscountForCustomerWithDisabilityTests
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
			SixPercentDiscountForCustomerWithDisability sixPercentDiscountForCustomerWithDisability = this.CreateSixPercentDiscountForCustomerWithDisability();


			// Assert

		}

		private SixPercentDiscountForCustomerWithDisability CreateSixPercentDiscountForCustomerWithDisability()
		{
			return new SixPercentDiscountForCustomerWithDisability();
		}
	}
}
