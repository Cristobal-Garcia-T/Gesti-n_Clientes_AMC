﻿using System;
using System.Windows;
using AccesoDB;
using Microsoft.EntityFrameworkCore;
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
                // Añadir Db a contenedor de servicios
                services.AddDbContext<ContextoDb>(options => options.UseSqlite("Data Source=GCAMCDB.db"));

                // Servicios en el contenedor, así se pueden inyectar sin necesidad de instanciar en el momento
                services.AddScoped<ServicioAdministradores>();
                services.AddScoped<ServicioBeneficiarios>();
                services.AddScoped<ServicioCasos>();
                services.AddScoped<ServicioClientesNaturales>();
                services.AddScoped<ServicioConsultores>();
                services.AddScoped<ServicioDocumentos>();
                services.AddScoped<ServicioEmpresas>();
                services.AddScoped<ServicioTareas>();
                services.AddScoped<ServicioLogin>();
            }).Build();

            BdCreada();
        }

        private void BdCreada()
        {
            // Este método se asegura que exista el archivo de la base de datos en el sistema, en caso contrario la crea
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
