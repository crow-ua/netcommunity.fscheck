using System;
using NETCommunity.FsCheck.Validators;
using Xunit;

namespace NETCommunity.FsCheck.Tests.Validators
{
	/// <summary>
	/// Unit tests covering YellowStickerDiscountValidator functionality.
	/// </summary>
	public class YellowStickerDiscountValidatorTests
    {
		/// <summary>
		/// This test verifies that if order was placed in a time slot eligible for discount, it will be applied.
		/// </summary>
	    [Fact]
	    public void OrderDate_Is_In_Valid_Range_Returns_True()
	    {
		    // Arrange
		    var orderDate = new DateTime(2018, 1, 5, 20, 30, 0);
		    var discountStart = new TimeSpan(20, 0, 0);
		    var discountEnd = new TimeSpan(21, 0, 0);
		    var target = new YellowStickerDiscountValidator(discountStart, discountEnd);

			// Act
		    var result = target.Validate(orderDate);

		    // Assert
			Assert.True(result);
	    }

		/// <summary>
		/// This test verifies that if order was placed in a time slot that is different from the one eligible for discount, it will not be applied.
		/// </summary>
		[Fact]
	    public void OrderDate_Is_Not_In_Valid_Range_Returns_False()
	    {
		    // Arrange
		    var orderDate = new DateTime(2018, 1, 5, 19, 30, 0);
			var discountStart = new TimeSpan(20, 0, 0);
		    var discountEnd = new TimeSpan(21, 0, 0);
			var target = new YellowStickerDiscountValidator(discountStart, discountEnd);

		    // Act
		    var result = target.Validate(orderDate);

		    // Assert
		    Assert.False(result);
	    }
	}
}