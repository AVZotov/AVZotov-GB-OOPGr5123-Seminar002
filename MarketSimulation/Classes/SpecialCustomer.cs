namespace MarketSimulation.Classes
{
    internal class SpecialCustomer : Customer
    {
        private readonly string _id;

        public SpecialCustomer(string name, string id) : base(name)
        {
            this._id = id;
        }

        protected override string GetName()
        {
            return base.GetName() + "id:" + _id;
        }
    }
}
