using MarketSimulation.Classes;

namespace MarketSimulation.Interfaces
{
    internal interface IReturnProducts
    {
        void ReturnRandomProduct();

        void ReturnRandomProducts(int amount);
    }
}
