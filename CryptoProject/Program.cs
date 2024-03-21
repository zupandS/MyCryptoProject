using CryptoProject.Interfaces;
using CryptoProject.Services;
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

            Application.Run(mainWindow);
        }

        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<Form1>();
            services.AddBinance();
            services.AddKucoin();
            services.AddBybit();
            services.AddBitget();

            services.AddScoped<ICryptoService, CryptoService>();
            services.AddScoped<ICryptoMapService, CryptoMapService>();

            return services.BuildServiceProvider();
        }
    }
}