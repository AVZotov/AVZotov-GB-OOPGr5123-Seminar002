namespace MarketSimulation.Classes
{
    /// <summary>
    /// Special class of customers who allowed to get discount in a market
    /// </summary>
    public class DiscountClient : Customer
    {
        /// <summary>
        /// Static field which count total amount of discount entities generated
        /// through the life of program
        /// </summary>
        private static int discountEntitiesCount = 0;
        /// <summary>
        /// name of discount action
        /// </summary>
        private string actionName;

        /// <summary>
        /// Property which get serial number of current entity
        /// </summary>
        public int DiscountNumber { get; private set; }

        public DiscountClient(string name, string actionName) : base(name)
        {
            discountEntitiesCount++;
            DiscountNumber = discountEntitiesCount;
            this.actionName = actionName;
        }
        
    }
}