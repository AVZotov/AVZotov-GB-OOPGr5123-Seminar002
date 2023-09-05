using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation.Interfaces
{
    internal interface IVisitorBehaviour
    {
        public string EnterMarketMessage();

        public string LeaveMarketMessage();
    }
}
