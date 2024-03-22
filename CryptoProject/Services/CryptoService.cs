using Binance.Net.Interfaces.Clients;
using Bitget.Net.Interfaces.Clients;
using Bybit.Net.Interfaces.Clients;
using CryptoProject.Interfaces;
using Kucoin.Net.Interfaces.Clients;

namespace CryptoProject.Services
{
    internal class CryptoService : ICryptoService
    {
        private readonly IBinanceSocketClient _binanceClient;
        private readonly IKucoinSocketClient _kucoinClient;
        private readonly IBybitSocketClient _bybitClient;
        private readonly IBitgetSocketClient _bitgetClient;

        private event Action<decimal> OnPriceUpdateBinance;
        private event Action<decimal> OnPriceUpdateKucoin;
        private event Action<decimal> OnPriceUpdateBybit;
        private event Action<decimal> OnPriceUpdateBitget;

        private readonly ICryptoMapService _cryptoMapService;

        public CryptoService(
            IBinanceSocketClient binanceClient,
            IKucoinSocketClient kucoinClient,
            IBybitSocketClient bybitClient,
            IBitgetSocketClient bitgetClient,
            ICryptoMapService cryptoMapService)
        {
            _binanceClient = binanceClient;
            _kucoinClient = kucoinClient;
            _bybitClient = bybitClient;
            _bitgetClient = bitgetClient;
            _cryptoMapService = cryptoMapService;
        }

        public async Task SubscribeGetPriceUpdatesBinanceAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice)
        {
            var result = await _binanceClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(currencyPair.ToString(), data => 
            {
                OnPriceUpdateBinance?.Invoke(data.Data.LastPrice);
                Task.Delay(delay).Wait();
            });

            if (result.Success)
                OnPriceUpdateBinance += OnPrice;
        }

        public async Task SubscribeGetPriceUpdatesBitgetAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice)
        {
            var result = await _bitgetClient.SpotApi.SubscribeToTickerUpdatesAsync(currencyPair.ToString(), data => 
            {
                OnPriceUpdateBitget?.Invoke(data.Data.LastPrice);
                Task.Delay(delay).Wait();
            });

            if (result.Success)
                OnPriceUpdateBitget += OnPrice;
        }

        public async Task SubscribeGetPriceUpdatesBybitAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice)
        {
            var result = await _bybitClient.V5SpotApi.SubscribeToTickerUpdatesAsync(currencyPair.ToString(), data => 
            {
                OnPriceUpdateBybit?.Invoke(data.Data.LastPrice);
                Task.Delay(delay).Wait();
            });

            if (result.Success)
                OnPriceUpdateBybit += OnPrice;
        }

        public async Task SubscribeGetPriceUpdatesKucoinAsync(CurrencyPair currencyPair, TimeSpan delay, Action<decimal> OnPrice)
        {
            var symbol = _cryptoMapService.KucoinMap(currencyPair);

            var result = await _kucoinClient.SpotApi.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                OnPriceUpdateKucoin?.Invoke((decimal)data.Data.LastPrice); 
                Task.Delay(delay).Wait();
            });

            if (result.Success)
                OnPriceUpdateKucoin += OnPrice;
        }
    }
}
