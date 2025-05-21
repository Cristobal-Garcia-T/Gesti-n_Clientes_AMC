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
        _usuariosViewModel = new TablaUsuariosViewModel(App.AppHost.Services.GetRequiredService<ServicioAdministradores>());
        DataContext = _usuariosViewModel;
        _usuariosViewModel.RecuperarTodos();
        InitializeComponent();
    }
}