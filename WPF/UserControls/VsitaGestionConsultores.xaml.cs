using System.Windows;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls
{
    public partial class VsitaGestionConsultores
    {
        public VsitaGestionConsultores()
        {
            InitializeComponent();
            var servico = App.AppHost.Services.GetRequiredService<ServicioConsultores>();
            DataContext = new GestionConsultoresViewModel(servico);
        }

        private void BotonCrear_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
