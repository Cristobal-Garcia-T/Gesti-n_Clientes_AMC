using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace registrar_casos
{
 
    public partial class RegistroUsuario : Window
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        private void BGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guardando el caso");
        }

        private void BCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BAdjuntar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("...");
        }
    }
}
