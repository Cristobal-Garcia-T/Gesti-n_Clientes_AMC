using System.Windows.Controls;
using ControladoresWPF;
using ControladoresWPF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls
{
    public partial class VistaGestionAdmin : UserControl
    {
        public VistaGestionAdmin()
        {
            InitializeComponent();

            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var vm = new GestionAdminViewModel(servicio);
            vm.RecuperarTodos();
            DataContext = vm;
        }
    }
}
