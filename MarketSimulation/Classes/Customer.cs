namespace MarketSimulation.Classes
{
    internal class Customer : Visitor
    {
        private List<Product> productBasket;

        public Customer(string name) : base(name)
        {
        }

        public override string LeaveMarketMessage()
        {
            return $"{name} left the market";
        }

        public override string EnterMarketMessage()
        {
            return $"{name} entered the market";
        }

        protected override string GetName()
        {
            return this.name;
        }

        protected override Visitor GetVisitor()
        {
            return this;
        }
    }
}
