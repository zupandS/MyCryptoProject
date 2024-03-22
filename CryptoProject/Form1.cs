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
            dataGridView1.Rows[0].Cells[0].Value = "BTC/USDT";

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

        private void OnBitgetGetPrice(decimal price)
        {
            dataGridView1.Rows[0].Cells[4].Value = price;
        }

        private void OnKucoinGetPrice(decimal price)
        {
            dataGridView1.Rows[0].Cells[3].Value = price;
        }

        private void OnBybitGetPrice(decimal price)
        {
            dataGridView1.Rows[0].Cells[2].Value = price;
        }

        private void OnBinanceGetPrice(decimal price)
        {
            dataGridView1.Rows[0].Cells[1].Value = price;
        }
    }
}
