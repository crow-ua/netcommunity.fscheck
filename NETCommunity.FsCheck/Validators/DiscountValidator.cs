using System.Linq;

namespace NETCommunity.FsCheck.Validators
{
	public class DiscountValidator
	{
		/*
		 * Customer table
		 * |Customer Id|Name|
		 * 
		 * Orders
		 * |Order Id|Customer Id|Product Id|
		 * 
		 * 
		SELECT customer_name, COUNT(DISTINCT product_ID) as products_count FROM customer_table
		INNER JOIN orders_table ON customer_table.customer_ID = orders_table.customer_ID
		GROUP BY customer_table.customer_ID, customer_name
		HAVING COUNT(DISTINCT product_ID) > 10
		 * 
		 * 
		 */
		public DiscountValidator(IOrdersRepository orders)
		{
		    
		}
		public bool Validate(IQueryable<Customer> customers, IQueryable<Order> orders)
		{
			var t = Queryable.Count((from customer in customers
				join order in orders on customer.Id equals order.CustomerId
				group order by order.ProductId));
			   


			return true;
		}
	}
}