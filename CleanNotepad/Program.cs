using CleanNotepad.InterfaceAdapter.Repository;
using CleanNotepad.UseCase;
using CleanNotepad.UseCase.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanNotepad
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

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            Notepad form = serviceProvider.GetRequiredService<Notepad>();
            Application.Run(form);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<Notepad>();

            // （広義の）依存性注入
            services.AddScoped<SaveNote>();

            // （狭義の）依存性注入
            services.AddScoped<IMemoRepository, MemoRepository>();
        }
    }
}