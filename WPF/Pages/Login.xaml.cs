using System.Windows;
using System.Windows.Controls;
using AccesoDB.Modelos;
using ControladoresWPF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Pages
{
    public partial class Login : Page
    {
        private readonly LoginViewModel _viewModel = new(App.AppHost.Services.GetService<ServicioLogin>()!);
        
        public Login()
        {
            DataContext = _viewModel;
            _viewModel.Logout();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usuarioEntrante = _viewModel.Login(Usuario.Text, Pass.Password, ComboBox.SelectionBoxItem.ToString());
            if ( usuarioEntrante == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Usuario.Clear();
                if (usuarioEntrante.GetType() == typeof(Administrador))
                {
                    NavigationService!.Navigate(new InterfazAdmin());
                }
                else
                {
                    NavigationService!.Navigate(new InterfazConsultor());
                }
            }
        }
    }
}
