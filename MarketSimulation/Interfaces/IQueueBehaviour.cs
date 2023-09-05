using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Interfaces
{
    public interface IQueueBehaviour
    {
        abstract string AddToQueue(IVisitorBehaviour visitor);

        public string RemoveFromQueue(IVisitorBehaviour visitor);

    }
}