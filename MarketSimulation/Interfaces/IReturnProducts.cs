using MarketSimulation.Classes;

namespace MarketSimulation.Interfaces
{
    /// <summary>
    /// Interface implements base methods for visitor
    /// to return products back to market.
    /// <para>
    /// Contract methods:
    /// <list type="bullet">
    /// <item>
    /// <description>ReturnProduct()</description>
    /// </item>
    /// <item>
    /// <description>ReturnProducts()</description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public interface IReturnProducts
    {
        /// <summary>
        /// Return 1 product back to market
        /// </summary>
        /// <returns>string based confirmation message</returns>
        string ReturnProduct();

        /// <summary>
        /// Return specified amount of products back to market
        /// </summary>
        /// <param name="amount">amount of products to be returned to market</param>
        /// <returns>string based confirmation message</returns>
        string ReturnProducts(int amount);
    }
}
