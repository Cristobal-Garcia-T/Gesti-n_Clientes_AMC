using System.Windows.Controls;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls
{
    public partial class GestionConsultores : UserControl
    {
        public GestionConsultores()
        {
            InitializeComponent();
            var servico = App.AppHost.Services.GetRequiredService<ServicioConsultores>();
            DataContext = new GestionConsultoresViewModel(servico);
        }
    }
}
