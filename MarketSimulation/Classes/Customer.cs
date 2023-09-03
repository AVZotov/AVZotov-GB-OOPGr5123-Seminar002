using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    internal class Customer : Visitor, IByProducts, IReturnProducts
    {
        protected List<Product> productBasket;

        protected bool isMakeChoice;
        
        protected bool isGetOrder;

        public Customer(string name) : base(name)
        {
            productBasket = new List<Product>();
        }

        public override string LeaveMarketMessage()
        {
            return $"{name} left the market";
        }

        public override string EnterMarketMessage()
        {
            return $"{name} entered the market";
        }

        public override string GetName()
        {
            return this.name;
        }

        public override Visitor GetVisitor()
        {
            return this;
        }

        public int GetBasketCount()
        {
            return productBasket.Count;
        }

        public List<Product> GetProducts()
        {
            return productBasket;
        }

        public void ReturnRandomProduct()
        {
            throw new NotImplementedException();
        }

        public void ReturnRandomProducts(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Product product = productBasket[i];
                productBasket.Remove(product);
            }
        }

        public void AddProduct(Product product)
        {
            productBasket.Add(product);
        }
    }
}
