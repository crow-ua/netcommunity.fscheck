using NETCommunity.FsCheck.Cart;

namespace NETCommunity.FsCheck.Discounts.Card
{
	// Discounts for discount card holders.
	public class DiscountCardDiscount : IItemDiscountRule
    {
	    private readonly IDiscountCard _discountCard;

	    public DiscountCardDiscount(IDiscountCard discountCard)
	    {
		    _discountCard = discountCard;
	    }
	    public decimal Apply(ICartLineItem cartLineItem)
	    {
		    return cartLineItem.Quantity * cartLineItem.Price * _discountCard.Discount;
	    }
    }
}