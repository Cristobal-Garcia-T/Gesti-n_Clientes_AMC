using System.Windows;
using ControladoresWPF;

namespace WPF
{
    public partial class GestionConsultores : Window
    {
        public GestionConsultores()
        {
            InitializeComponent();
            DataContext = new GestionConsultoresViewModel();
        }
    }
}
