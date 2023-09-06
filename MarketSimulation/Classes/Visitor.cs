using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    /// <summary>
    /// This abstract base class is a parent class for all 
    /// entities visiting market
    /// <para>
    /// Impements <c>IVisitorBehaviour</c> interface
    /// </para>
    /// </summary>
    public abstract class Visitor : IVisitorBehaviour 
    {
        protected string name;

        protected Visitor(string name)
        {
            this.name = name;
        }

        public abstract Visitor GetVisitor();

        /// <summary>
        /// Method to get Visitor's name
        /// </summary>
        /// <returns>string</returns>
        public abstract string GetName();

        public abstract string EnterMarketMessage();

        public abstract string LeaveMarketMessage();
    }
}
