using WinformsApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                    Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
           {
               // Register DbContext with SQLite
               services.AddDbContext<AppDbContext>(options =>
                   options.UseSqlite("Data Source=appdata.db"));

               // Register repositories
               services.AddTransient<ICustomerRepository, CustomerRepository>();

               // Register main form
               services.AddSingleton<MainForm>();

               // Register other forms
               services.AddTransient<CustomerForm>();
           });
    }
}