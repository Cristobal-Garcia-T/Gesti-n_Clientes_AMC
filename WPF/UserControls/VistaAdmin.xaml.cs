using System.Windows.Controls;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls;

public partial class VistaAdmin : UserControl
{
    private readonly TablaUsuariosViewModel _usuariosViewModel;
    public VistaAdmin()
    {
        //Inyección de servicios al ViewModel
        var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
        _usuariosViewModel = new TablaUsuariosViewModel(servicio);
        //Definición de la fuente de datos para la vista
        DataContext = _usuariosViewModel;
        //En contrucción la tabla recupera todos los registros
        _usuariosViewModel.RecuperarTodos();
        InitializeComponent();
    }
}