﻿using MarketSimulation.Interfaces;

namespace MarketSimulation.Classes
{
    public class Customer : Visitor, IReturnProducts
    {
        private bool isMakeChoice;

        private bool isGetOrder;

        internal bool IsMakeChoice { get => isMakeChoice; set => isMakeChoice = value; }
        internal bool IsGetOrder { get => isGetOrder; set => isGetOrder = value; }

        public Customer(string name) : base(name)
        {
        }

        public override string LeaveMarketMessage() => $"{name} left the market";

        public override string EnterMarketMessage() => $"{name} entered the market";

        public override string GetName() => this.name;

        public override Visitor GetVisitor() => this;

        public string ReturnProduct() => $"Decided to return 1 product";

        public string ReturnProducts(int amount) => $"Decided to return {amount} products";
    }
}
