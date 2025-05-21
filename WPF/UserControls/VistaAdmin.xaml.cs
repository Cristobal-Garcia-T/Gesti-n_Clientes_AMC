using System.Windows.Controls;
using AccesoDB;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.UserControls;

public partial class VistaAdmin : UserControl
{
    private readonly VistaAdminViewModel _viewModel;
    public VistaAdmin()
    {
        _viewModel = new VistaAdminViewModel(App.AppHost.Services.GetRequiredService<ServicioAdministradores>());
        DataContext = _viewModel;
        _viewModel.RecuperarTodos();
        InitializeComponent();
    }
}