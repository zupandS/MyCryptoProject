using CryptoProject.Interfaces;

namespace CryptoProject.Services
{
    public class CryptoMapService : ICryptoMapService
    {
        public string KucoinMap(CurrencyPair currencyPair)
        {
            return "BTC-USDT";
        }
    }
}
