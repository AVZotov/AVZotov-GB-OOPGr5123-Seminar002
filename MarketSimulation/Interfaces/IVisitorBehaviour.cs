using MarketSimulation.Classes;

namespace MarketSimulation.Interfaces
{
    public interface IVisitorBehaviour
    {
        public string EnterMarketMessage();

        public string LeaveMarketMessage();

        public Visitor GetVisitor();
    }
}
