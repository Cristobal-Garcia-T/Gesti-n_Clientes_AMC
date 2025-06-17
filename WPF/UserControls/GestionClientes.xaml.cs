using System.Windows;
using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Servicios;
using WPF.Windows.Formularios;

namespace WPF.UserControls
{
    public partial class GestionClientes
    {
        public GestionClientes()
        {
            var servicioClientes = App.AppHost.Services.GetRequiredService<ServicioClientes>();
            var usuarioLogueadoId = App.AppHost.Services.GetRequiredService<ServicioLogin>().UsuarioActual!.Id;
            var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
            DataContext = new GestionClientesViewModel(servicioClientes, usuarioLogueadoId, mensajero);
            InitializeComponent();
        }

        private void BtnAgregar_OnClick(object sender, RoutedEventArgs e)
        {
            new FormularioCrearCliente().ShowDialog();
        }

        private void BtnEditar_OnClick(object sender, RoutedEventArgs e)
        {
            new FormularioActualizarCliente().ShowDialog();
        }
    }

}
