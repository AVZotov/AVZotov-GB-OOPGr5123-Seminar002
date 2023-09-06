using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Services
{
    /// <summary>
    /// Static class with supporting methods based on Random
    /// </summary>
    public static class Utilities
    {
        public static int GetRandomInt(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }

        /// <summary>
        /// Methods returns true if randomly generated double 
        /// is lower or equal to parameter passed to this method
        /// </summary>
        /// <param name="chance">max value (including) based on chance from 0 to 99.9%
        /// must be in double interpretaion</param>
        /// <returns><c>bool</c></returns>
        public static bool GetChance(double chance)
        {
            return new Random().NextDouble() <= chance;
        }
    }
}