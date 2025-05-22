using System.Windows;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Obtención del servicio necesario para conectar a la tabla "Adminitradores"
            //e inyección del servicio en el ViewModel de la ventana
            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var viewModel = new MainWindowViewModel(servicio);
            InitializeComponent();
            //Se verifica si existe algún registro en la tabla "Administradores", en caso contrario
            //se le indica al usuario que necesita registrar uno.
            if (viewModel.AdminNoExistente())
            {
                new AdvertenciaSinAdmin().ShowDialog();
            }
        }
    }
}