using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    public class Customer : Visitor, IByProducts, IReturnProducts
    {
        protected List<Product> productBasket;

        private bool isMakeChoice;

        private bool isGetOrder;

        internal bool IsMakeChoice { get => isMakeChoice; set => isMakeChoice = value; }
        internal bool IsGetOrder { get => isGetOrder; set => isGetOrder = value; }

        public Customer(string name) : base(name)
        {
            productBasket = new List<Product>();
        }

        public override string LeaveMarketMessage() => $"{name} left the market";

        public override string EnterMarketMessage() => $"{name} entered the market";

        public override string GetName() => this.name;

        public override Visitor GetVisitor() => this;

        public int GetBasketCount() => productBasket.Count;

        public List<Product> GetProducts() => productBasket;

        public void ReturnRandomProduct() => productBasket.Remove(productBasket[0]);

        public void ReturnRandomProducts(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Product product = productBasket[i];
                productBasket.Remove(product);
            }
        }

        public void AddProduct(Product product) => productBasket.Add(product);
    }
}
