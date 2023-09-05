namespace MarketSimulation.Classes
{
    public class DiscountClient : Customer
    {
        private static int discountEntitiesCount = 0;

        public int thisVisitorNubmer { get; private set; }

        public DiscountClient(string name) : base(name)
        {
            discountEntitiesCount++;
            thisVisitorNubmer = discountEntitiesCount;
        }
        
    }
}