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

namespace Proyecto_Ing_software
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Caso> casos = new List<Caso>
        {
            new Caso { Id = 1, PersonalidadTributaria = "Natural", Giro = "Comercio", Nombre = "Juan Pérez", Rut = "12.345.678-9", Email = "juan.perez@email.com", Telefono = "912345678", Direccion = "Av. Siempre Viva 123" },
            new Caso { Id = 2, PersonalidadTributaria = "Jurídica", Giro = "Consultoría", Nombre = "Empresa ABC", Rut = "76.543.210-K", Email = "contacto@empresaabc.cl", Telefono = "987654321", Direccion = "Calle Esperanza 456" },
            new Caso { Id = 3, PersonalidadTributaria = "Natural", Giro = "Servicios", Nombre = "Laura González", Rut = "11.223.344-5", Email = "laura.gonzalez@gmail.com", Telefono = "912345679", Direccion = "Pasaje Azul 321" },
            new Caso { Id = 4, PersonalidadTributaria = "Jurídica", Giro = "Transporte", Nombre = "Transportes Norte", Rut = "77.888.999-1", Email = "info@tnorte.cl", Telefono = "933221100", Direccion = "Ruta 5 Norte, km 32" },
            new Caso { Id = 5, PersonalidadTributaria = "Natural", Giro = "Educación", Nombre = "Carlos Rivas", Rut = "15.667.890-2", Email = "carlos.rivas@edu.cl", Telefono = "945612300", Direccion = "Av. Central 789" }
        };

            CasosDataGrid.ItemsSource = casos;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        public class Caso
        {
            public int Id { get; set; }
            public string PersonalidadTributaria { get; set; }
            public string Giro { get; set; }
            public string Nombre { get; set; }
            public string Rut { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
        }
    }

}
