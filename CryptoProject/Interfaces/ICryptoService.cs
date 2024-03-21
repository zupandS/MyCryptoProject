namespace CryptoProject.Interfaces
{
    public interface ICryptoService
    {
        Task SubscribeGetPriceUpdatesBinanceAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice);

        Task SubscribeGetPriceUpdatesKucoinAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice);

        Task SubscribeGetPriceUpdatesBybitAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice);

        Task SubscribeGetPriceUpdatesBitgetAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice);
    }
}
