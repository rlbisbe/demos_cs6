namespace CSharpSixReview
{
    class NullOperator
    {
        public string GetCustomerFromOrder(Order order)
        {
            if (order == null)
            {
                return null;
            }
            if (order.Customer == null)
            {
                return null;
            }

            return order.Customer.Name;
        }

        public string GetCustomerFromOrderNew(Order order)
        {
            return order?.Customer?.Name;
        }

    }
}
