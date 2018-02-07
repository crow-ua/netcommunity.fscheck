
using Moq;
using NETCommunity.FsCheck.Discounts.CustomerCharacteristic;

namespace NETCommunity.FsCheck.Tests.Discounts.CustomerCharacteristic
{
	
	public class TenPercentEmployeeDiscountTests
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
			TenPercentEmployeeDiscount tenPercentEmployeeDiscount = this.CreateTenPercentEmployeeDiscount();


			// Assert

		}

		private TenPercentEmployeeDiscount CreateTenPercentEmployeeDiscount()
		{
			return new TenPercentEmployeeDiscount();
		}
	}
}
