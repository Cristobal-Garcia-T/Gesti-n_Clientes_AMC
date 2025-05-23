using System.Windows.Controls;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls
{
    public partial class VistaAdmin : UserControl
    {
        public VistaAdmin()
        {
            InitializeComponent();

            var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
            var vm = new TablaUsuariosViewModel(servicio);
            vm.RecuperarTodos();
            this.DataContext = vm;
        }
    }
}
