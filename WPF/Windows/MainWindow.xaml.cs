using System.Windows;
using AccesoDB;
using ControladoresWPF;
using Servicios;

namespace WPF.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var viewModel = new MainWindowViewModel(new ServicioAdministradores(new ContextoDb()));
            InitializeComponent();
            if (viewModel.AdminNoExistente())
            {
                new FormularioCrearAdmin().ShowDialog();
            }
        }
    }
}