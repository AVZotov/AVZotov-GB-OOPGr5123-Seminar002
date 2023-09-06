using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Interfaces
{
    /// <summary>
    /// Interface implements base methods for market queue
    /// to store visitors
    /// <para>
    /// Contract methods:
    /// <list type="bullet">
    /// <item>
    /// <description>AddToQueue()</description>
    /// </item>
    /// <item>
    /// <description>RemoveFromQueue()</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public interface IQueueBehaviour
    {
        /// <summary>
        /// Method to add Visitor to the market
        /// </summary>
        /// <param name="visitor">Visitor to be added to queue</param>
        /// <returns>string based confirmation</returns>
        abstract string AddToQueue(IVisitorBehaviour visitor);

        /// <summary>
        /// Method to remove exact Visitor from queue
        /// </summary>
        /// <param name="visitor">Visitor to be deleted from queue</param>
        /// <returns>string based confirmation</returns>
        public string RemoveFromQueue(IVisitorBehaviour visitor);

    }
}