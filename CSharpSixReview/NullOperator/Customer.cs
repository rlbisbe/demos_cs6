namespace CSharpSixReview
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Order
    {
        public Customer Customer { get; set; }
        public string Description { get; set; }
    }
}
