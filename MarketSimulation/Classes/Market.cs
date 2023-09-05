using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    public class Market : IQueueBehaviour
    {
        private List<IVisitorBehaviour> visitors;

        public Market()
        {
            visitors = new List<IVisitorBehaviour>();
        }
        void IQueueBehaviour.AddToQueue(IVisitorBehaviour visitor)
        {
            visitors.Add(visitor);
        }

        void IQueueBehaviour.RemoveFromQueue(IVisitorBehaviour visitor)
        {
            visitors.Remove(visitor);
        }
    }
}