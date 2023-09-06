using MarketSimulation.Classes;

/// <summary>
/// This program is Market simulation with using Interfaces,
/// abstract classes and inheritance
/// As additional task simple Logger added to store status in file
/// </summary>

int maxAmountOfActionClients = 1;
Market market = new(maxAmountOfActionClients);
market.Start();