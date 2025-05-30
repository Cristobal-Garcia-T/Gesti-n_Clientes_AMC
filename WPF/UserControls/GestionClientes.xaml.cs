using ControladoresWPF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls
{
    public partial class GestionClientes
    {
        public GestionClientes()
        {
            var servicioClientesNaturales = App.AppHost.Services.GetRequiredService<ServicioClientesNaturales>();
            var servicioEmpresas = App.AppHost.Services.GetRequiredService<ServicioEmpresas>();
            DataContext = new GestionClientesViewModel(servicioClientesNaturales, servicioEmpresas);
            InitializeComponent();
        }
    }

}
