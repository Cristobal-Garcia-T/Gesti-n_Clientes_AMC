using System.Windows;
using AccesoDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Servicios;
using WPF.Windows;

namespace WPF
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                //Añadir Db a conteneedor de servicios
                services.AddDbContext<ContextoDb>(options => options.UseSqlite("Data Source=GCAMCDB.db"));
                
                //Servicios en el contenedor, así se pueden inyectar sin necesidad de instanciar en el momento
                services.AddScoped<ServicioAdministradores>();
                services.AddScoped<ServicioBeneficiarios>();
                services.AddScoped<ServicioCasos>();
                services.AddScoped<ServicioClientesNaturales>();
                services.AddScoped<ServicioConsultores>();
                services.AddScoped<ServicioDocumentos>();
                services.AddScoped<ServicioEmpresas>();
                services.AddScoped<ServicioTareas>();
                
            }).Build();

            BdCreada();
        }

        private void BdCreada()
        {
            using var scope = AppHost.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<ContextoDb>();
            db.Database.EnsureCreated();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await AppHost.StartAsync();
        }
    }

}
