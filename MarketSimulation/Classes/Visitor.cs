using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    public abstract class Visitor : IVisitorBehaviour
    {
        protected string name;

        protected Visitor(string name)
        {
            this.name = name;
        }

        public abstract Visitor GetVisitor();

        public abstract string GetName();

        public abstract string EnterMarketMessage();

        public abstract string LeaveMarketMessage();
    }
}
