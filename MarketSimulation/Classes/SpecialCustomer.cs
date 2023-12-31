﻿namespace MarketSimulation.Classes
{
    /// <summary>
    /// This class decribe functionality of special customers
    /// <para>Extends: <c>Customer</c> class</para>
    /// </summary>
    public class SpecialCustomer : Customer
    {
        private readonly string _id;

        public SpecialCustomer(string name, string id) : base(name)
        {
            this._id = id;
        }

        public override string GetName()
        {
            return "[" + base.GetName() + " id:" + _id + "]";
        }
    }
}
