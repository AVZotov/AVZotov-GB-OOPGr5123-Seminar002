using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
