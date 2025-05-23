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
            
            //Obtención del servicio necesario para conectar a la tabla "Administradores"
            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var viewModel = new MainWindowViewModel(servicio);
            this.DataContext = viewModel;


            InitializeComponent();

            //Se verifica si existe algún registro en la tabla "Administradores"
            if (viewModel.AdminNoExistente())
            {
                new AdvertenciaSinAdmin().ShowDialog();
            }

            // ABRIR LA VENTANA DE GESTIÓN DE CONSULTORES
            var ventanaConsultores = new GestionConsultores();
            ventanaConsultores.Show();
        }
    }
}
