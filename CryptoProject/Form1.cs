using CryptoProject.Interfaces;

namespace CryptoProject
{
    public partial class Form1 : Form
    {
        private readonly ICryptoService _cryptoService;

        public Form1(ICryptoService cryptoService)
        {
            InitializeComponent();
            _cryptoService = cryptoService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await _cryptoService.SubscribeGetPriceUpdatesBinanceAsync(
                CurrencyPair.BTCUSDT,
                TimeSpan.FromSeconds(5),
                OnBinanceGetPrice);

            await _cryptoService.SubscribeGetPriceUpdatesBybitAsync(
                CurrencyPair.BTCUSDT,
                TimeSpan.FromSeconds(5),
                OnBybitGetPrice);

            await _cryptoService.SubscribeGetPriceUpdatesKucoinAsync(
                CurrencyPair.BTCUSDT,
                TimeSpan.FromSeconds(5),
                OnKucoinGetPrice);

            await _cryptoService.SubscribeGetPriceUpdatesBitgetAsync(
                CurrencyPair.BTCUSDT,
                TimeSpan.FromSeconds(5),
                OnBitgetGetPrice);
        }

        private void OnBitgetGetPrice(decimal obj)
        {

        }

        private void OnKucoinGetPrice(decimal obj)
        {

        }

        private void OnBybitGetPrice(decimal obj)
        {

        }

        private void OnBinanceGetPrice(decimal obj)
        {

        }
    }
}
