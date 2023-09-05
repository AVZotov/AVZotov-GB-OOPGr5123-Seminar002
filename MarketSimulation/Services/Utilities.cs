using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketSimulation.Services
{
    public static class Utilities
    {
        public static int GetRandomInt(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }

        public static bool GetChance(double chance)
        {
            return new Random().NextDouble() <= chance;
        }
    }
}