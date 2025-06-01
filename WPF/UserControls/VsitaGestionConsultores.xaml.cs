using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Servicios;
using WPF.Windows.Formularios;

namespace WPF.UserControls
{
    public partial class VsitaGestionConsultores
    {
        public VsitaGestionConsultores()
        {
            InitializeComponent();
            var servico = App.AppHost.Services.GetRequiredService<ServicioConsultores>();
            var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
            DataContext = new GestionConsultoresViewModel(servico, mensajero);
        }

        private void BotonCrear_OnClick(object sender, RoutedEventArgs e)
        {
            new FormularioCrearConsultor().ShowDialog();
        }
    }
}
