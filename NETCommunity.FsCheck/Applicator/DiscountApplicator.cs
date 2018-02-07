using System.Collections.Generic;
using System.Linq;
using NETCommunity.FsCheck.Cart;
using NETCommunity.FsCheck.Discounts;
using NETCommunity.FsCheck.Discounts.Bulk;
using NETCommunity.FsCheck.Discounts.Trade;

namespace NETCommunity.FsCheck.Applicator
{
    public class DiscountApplicator
    {
	    private readonly IList<IItemDiscountRule> _discountRules = new List<IItemDiscountRule>
	    {
		    new TenPercentForTenItemsPurchasedLastMonthCumulativeQuantityDiscount(),
            new TwoPercentTradeDiscount()
        };

	    public bool Checkout(ICustomer customer, ICart cart)
	    {
            //TODO:validate customer
	        // ReSharper disable once NotAccessedVariable
	        var totalWithDiscount = _discountRules
                .Sum(discountRule => cart.CartItems.Sum(cartCartItem => discountRule.Apply(cartCartItem)));
	        //TODO:pass total further
	        return true;
	    }
    }
}