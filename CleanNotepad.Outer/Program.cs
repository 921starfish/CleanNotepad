using CleanNotepad.InterfaceAdapterForDB;
using CleanNotepad.InterfaceAdapterForDB.Repository;
using CleanNotepad.InterfaceAdapterForUI;
using CleanNotepad.Outer.UI;
using CleanNotepad.UseCase;
using CleanNotepad.UseCase.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanNotepad.Outer
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

            services.AddScoped<MemoController>();

            services.AddScoped<SaveNote>();
            services.AddScoped<LoadNote>();

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseInMemoryDatabase("CleanNotepadDB"));

            services.AddScoped<IMemoRepository, MemoRepository>();
        }
    }
}