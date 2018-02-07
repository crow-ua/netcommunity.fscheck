using System;

namespace NETCommunity.FsCheck.Validators
{
    public class YellowStickerDiscountValidator : IValidator
    {
	    private readonly TimeSpan _discountStartTime;
	    private readonly TimeSpan _discountEndTime;

	    public YellowStickerDiscountValidator(TimeSpan discountStartTime, TimeSpan discountEndTime)
	    {
		    _discountStartTime = discountStartTime;
		    _discountEndTime = discountEndTime;
	    }

	    public bool Validate(DateTime orderDate)
	    {
		    var success = orderDate.TimeOfDay >= _discountStartTime 
		                  && orderDate.TimeOfDay <= _discountEndTime;
			return success;
	    }
    }
}