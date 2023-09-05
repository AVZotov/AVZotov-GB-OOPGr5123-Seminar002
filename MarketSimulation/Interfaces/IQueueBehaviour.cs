using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Interfaces
{
    public interface IQueueBehaviour
    {
        public void AddToQueue(IVisitorBehaviour visitor);

        void RemoveFromQueue(IVisitorBehaviour visitor);

    }
}