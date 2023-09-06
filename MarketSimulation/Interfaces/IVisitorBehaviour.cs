using MarketSimulation.Classes;
using System.Collections.Specialized;

namespace MarketSimulation.Interfaces
{
    /// <summary>
    /// Interface implements base methods for visitor
    /// to interact with market.
    /// <para>
    /// Contract methods:
    /// <list type="bullet">
    /// <item>
    /// <description>EnterMarketMessage()</description>
    /// </item>
    /// <item>
    /// <description>LeaveMarketMessage()</description>
    /// </item>
    /// <item>
    /// <description>GetVisitor()</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public interface IVisitorBehaviour
    {
        /// <summary>
        /// Welcome notification from visitor
        /// </summary>
        /// <returns>string</returns>
        public string EnterMarketMessage();

        /// <summary>
        /// Leave notification from visitor
        /// </summary>
        /// <returns>string</returns>
        public string LeaveMarketMessage();

        /// <summary>
        /// Method to get current instance
        /// </summary>
        /// <returns>Visitor class</returns>
        public Visitor GetVisitor();
    }
}
