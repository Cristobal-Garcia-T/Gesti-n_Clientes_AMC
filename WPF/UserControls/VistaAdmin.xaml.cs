using System.Windows.Controls;
using AccesoDB;
using ControladoresWPF;
using Servicios;

namespace WPF.UserControls;

public partial class VistaAdmin : UserControl
{
    private readonly VistaAdminViewModel _viewModel;
    public VistaAdmin()
    {
        _viewModel = new VistaAdminViewModel(new ServicioAdministradores(new ContextoDb()));
        DataContext = _viewModel;
        InitializeComponent();
    }
}