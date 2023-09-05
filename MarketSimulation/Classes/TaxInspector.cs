using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Classes
{
    public class TaxInspector : Visitor
    {
        public TaxInspector(string name) : base(name)
        {
        }

        public override string LeaveMarketMessage() => $"{name} left the market";

        public override string EnterMarketMessage() => $"{name} entered the market";

        public string MakeInspection()
        {
            GetRandomProductsForCheck();
            ReturnProducts();
            return "Inspection passed succesfully!";
        }

        private void GetRandomProductsForCheck() => System.Console.WriteLine($"Tax inspector selected products for check");

        private void ReturnProducts() => System.Console.WriteLine("Tax inspector returned checked products");

        public override Visitor GetVisitor() => this;

        public override string GetName() => this.name;
    }
}