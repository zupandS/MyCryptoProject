using Microsoft.Extensions.DependencyInjection;

namespace CryptoProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using var provider = ConfigureServices();

            var mainWindow = provider.GetRequiredService<Form1>();

            Application.Run(new Form1());
        }

        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<Form1>();
            services.AddBinance();
            services.AddKucoin();
            services.AddBybit();
            services.AddBitget();

            return services.BuildServiceProvider();
        }
    }
}