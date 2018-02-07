
using Moq;
using NETCommunity.FsCheck.Discounts.Rebate;

namespace NETCommunity.FsCheck.Tests.Discounts.Rebate
{
	
	public class OnePercentRebateForReturningCustomersTests
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
			OnePercentRebateForReturningCustomers onePercentRebateForReturningCustomers = this.CreateOnePercentRebateForReturningCustomers();


			// Assert

		}

		private OnePercentRebateForReturningCustomers CreateOnePercentRebateForReturningCustomers()
		{
			return new OnePercentRebateForReturningCustomers();
		}
	}
}
