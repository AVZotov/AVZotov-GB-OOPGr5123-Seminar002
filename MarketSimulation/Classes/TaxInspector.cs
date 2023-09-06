using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Classes
{
    /// <summary>
    /// Describe the entity inspector whom inspect products in market
    /// <para>
    /// Extends <c>Visitor</c>
    /// </para>
    /// </summary>
    public class TaxInspector : Visitor
    {
        public TaxInspector(string name) : base(name)
        {
        }

        public override string LeaveMarketMessage() => $"{name} left the market";

        public override string EnterMarketMessage() => $"{name} entered the market";

        /// <summary>
        /// Method simulate inpection
        /// </summary>
        /// <returns>string based notification</returns>
        public string MakeInspection() => "Inspection passed succesfully!";

        public override Visitor GetVisitor() => this;

        public override string GetName() => this.name;
    }
}