using System;
using FsCheck;
using FsCheck.Xunit;
using NETCommunity.FsCheck.Validators;
using Xunit;

namespace NETCommunity.FsCheck.Tests.Validators
{
	/// <summary>
	/// FsCheck tests.
	/// </summary>
	public class YellowStickerDiscountValidatorFsCheckTests
	{
	    //[Property]
	    public bool Random_OrderDate_Will_Fail_Simple(DateTime orderDate)
	    {
	        var discountStart = new TimeSpan(20, 0, 0);
	        var discountEnd = new TimeSpan(21, 0, 0);
	        var target = new YellowStickerDiscountValidator(discountStart, discountEnd);
	        return target.Validate(orderDate);
	    }

        [Property]
		public void Random_OrderDate_Will_Fail()
		{
			var discountStart = new TimeSpan(20, 0, 0);
			var discountEnd = new TimeSpan(21, 0, 0);
			var target = new YellowStickerDiscountValidator(discountStart, discountEnd);

			Assert.Throws<Exception>(() => 
			    Prop.ForAll(Arb.Default.DateTime(), orderDate => target.Validate(orderDate)).QuickCheckThrowOnFailure());
		}

		[Property]
		public void OrderDate_Is_In_Target_Period_Returns_True()
		{
			var discountStart = new TimeSpan(20, 0, 0);
			var discountEnd = new TimeSpan(21, 0, 0);
			var target = new YellowStickerDiscountValidator(discountStart, discountEnd);

			Prop.ForAll(GetRandomOrderDates(discountStart, discountEnd), orderDate => target.Validate(orderDate))
				.VerboseCheckThrowOnFailure();
		}
		private static Arbitrary<DateTime> GetRandomOrderDates(TimeSpan start, TimeSpan end, bool insidePeriod = true)
		{
			var validDates = Arb.Default.DateTime()
				.Generator
                .Where(dateTime => insidePeriod
			        ? dateTime.TimeOfDay >= start && dateTime.TimeOfDay <= end
			        : dateTime.TimeOfDay < start || dateTime.TimeOfDay > end)
                .ToArbitrary();
			return validDates;
		}

		[Property]
		public void OrderDate_Is_Not_In_Target_Period_Returns_False()
		{
			var discountStart = new TimeSpan(20, 0, 0);
			var discountEnd = new TimeSpan(21, 0, 0);
			var target = new YellowStickerDiscountValidator(discountStart, discountEnd);

			Prop.ForAll(GetRandomOrderDates(discountStart, discountEnd, insidePeriod:false), orderDate => !target.Validate(orderDate))
				.VerboseCheckThrowOnFailure();
		}

        #region Configuration

        //private readonly ITestOutputHelper _TestOutputHelper;
        //public YellowStickerDiscountValidatorFsCheckTests(ITestOutputHelper testOutputHelper)
        //{
        //	_TestOutputHelper = testOutputHelper;
        //}

        //[Property(QuietOnSuccess = false, MaxTest = 1000)]
        //public bool Test_To_Be_Run_Thousand_Times()
        //{
        //	return true;
        //}

        #endregion

        #region Samples
        //[Property(QuietOnSuccess = true)]
        //public bool Bcl(int[] xs)
        //{
        //	return xs.Reverse().Reverse().SequenceEqual(xs);
        //}

        //[Property(QuietOnSuccess = true)]
        //public void Bcl2(int[] xs)
        //{
        //	if (true == xs.Reverse().Reverse().SequenceEqual(xs))
        //	{
        //		// all ok
        //	}
        //	else
        //	{
        //		throw new Exception("Fail at life");
        //	}
        //}

        //[Property]
        //public bool ShouldFail_1(int[] xs)
        //{
        //	return xs.BadReverse1().SequenceEqual(xs.Reverse());
        //}

        //[Property]
        //public bool ShouldFail_2(int[] xs)
        //{
        //	return xs.BadReverse2().SequenceEqual(xs.Reverse());
        //}

        //[Property(MaxTest = 1000, EndSize = 5)]
        //public bool ShouldFail_3(int[] xs)
        //{
        //	return xs.BadReverse3().SequenceEqual(xs.Reverse());
        //}

        //[Property]
        //public bool ShouldFail_Exception(int[] xs)
        //{
        //	throw new InvalidOperationException("Test failed!");
        //}
        #endregion
    }
    
    #region Extensions
    //public static class ExtensionMethods
    //{
    //	public static IEnumerable<TSource> BadReverse1<TSource>(this IEnumerable<TSource> source)
    //	{
    //		return source;
    //	}

    //	public static IEnumerable<TSource> BadReverse2<TSource>(this IEnumerable<TSource> source)
    //	{
    //		var badReverse2 = source as IList<TSource> ?? source.ToList();
    //		return badReverse2.Count() > 10 ? badReverse2 : badReverse2.Reverse();
    //	}

    //	public static IEnumerable<TSource> BadReverse3<TSource>(this IEnumerable<TSource> source)
    //		where TSource : IEquatable<TSource>
    //	{
    //		var list = source.ToList();
    //		var isOrdered = list.SequenceEqual(list.AsEnumerable().OrderBy(_ => _));
    //		return list.Count >= 3 && isOrdered ? list : list.AsEnumerable().Reverse();
    //	}
    //}
    #endregion
}