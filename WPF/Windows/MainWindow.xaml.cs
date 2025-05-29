using System.Windows;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;
using WPF.Windows.Modals;

namespace WPF.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Obtención del servicio necesario para conectar a la tabla "Administradores"
            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var viewModel = new MainWindowViewModel(servicio);
            
            InitializeComponent();

            //Se verifica si existe algún registro en la tabla "Administradores"
            if (viewModel.AdminNoExistente())
            {
                var resultado = new AdvertenciaSinAdmin().ShowDialog();
                if (resultado == false)
                    Application.Current.Shutdown();
            }
        }
    }
}
