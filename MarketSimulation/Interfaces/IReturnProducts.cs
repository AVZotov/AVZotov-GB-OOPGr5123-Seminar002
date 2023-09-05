using MarketSimulation.Classes;

namespace MarketSimulation.Interfaces
{
    public interface IReturnProducts
    {
        void ReturnRandomProduct();

        void ReturnRandomProducts(int amount);
    }
}
