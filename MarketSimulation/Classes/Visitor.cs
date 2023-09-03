using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    internal abstract class Visitor : IVisitorBehaviour
    {
        protected string name;

        protected Visitor(string name)
        {
            this.name = name;
        }

        protected abstract Visitor GetVisitor();

        protected abstract string GetName();

        public abstract string EnterMarketMessage();

        public abstract string LeaveMarketMessage();
    }
}
