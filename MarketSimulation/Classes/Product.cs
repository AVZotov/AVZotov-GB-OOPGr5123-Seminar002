namespace MarketSimulation.Classes
{
    internal class Product
    {
        private readonly Guid _id;

        public Product()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }

        public override bool Equals(object? obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product other = (Product)obj;
            return this._id.Equals(other.GetId());
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public override string ToString()
        {
            return $"Product: {_id.ToString()[..8]}";
        }
    }
}