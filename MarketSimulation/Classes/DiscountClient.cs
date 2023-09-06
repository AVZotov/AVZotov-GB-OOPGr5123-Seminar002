namespace MarketSimulation.Classes
{
    public class DiscountClient : Customer
    {
        private static int discountEntitiesCount = 0;
        private string actionName;

        public int DiscountNumber { get; private set; }

        public DiscountClient(string name, string actionName) : base(name)
        {
            discountEntitiesCount++;
            DiscountNumber = discountEntitiesCount;
            this.actionName = actionName;
        }
        
    }
}