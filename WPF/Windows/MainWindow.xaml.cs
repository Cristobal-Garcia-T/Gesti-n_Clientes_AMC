using System.Windows;
using AccesoDB;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var viewModel = new MainWindowViewModel(servicio);
            InitializeComponent();
            if (viewModel.AdminNoExistente())
            {
                new AdvertenciaSinAdmin().ShowDialog();
            }
        }
    }
}