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
    /// <item>
    /// <description>GetVisitor()</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public interface IQueueBehaviour
    {
        abstract string AddToQueue(IVisitorBehaviour visitor);

        public string RemoveFromQueue(IVisitorBehaviour visitor);

    }
}