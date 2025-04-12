
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SqliteDataAccess.Services;

namespace WinformsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            // Get the main form from DI container
            var mainForm = host.Services.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        public static IHostBuilder CreateHostBuilder() => 
            Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
                    {
                        config.SetBasePath(Directory.GetCurrentDirectory());
                        config.AddJsonFile("appsettings.json", optional: false);
                    }).
            ConfigureServices((context, services) =>
           {
               // Register data services from library
               services.AddDataServices(context.Configuration);

               // Register main form
               services.AddTransient<MainForm>();

               // Register other forms
               services.AddTransient<CustomerForm>();
           });
    }
}