using System.Security.Cryptography;
using System.Text;
using System.Windows;
using AccesoDB;
using AccesoDB.Modelos;
using ControladoresWPF;
using Servicios;

namespace WPF.Windows;

public partial class FormularioCrearAdmin : Window
{
    public FormularioCrearAdmin()
    {
        InitializeComponent();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        var servicio = new ServicioAdministradores(new ContextoDb());
        new FormularioCrearAdminViewModel(servicio).AgregarAdministrador(new Administrador
        {
            Nombres = TxtNombres.Text,
            Apellidos = TxtApellidos.Text,
            Id = TxtRut.Text,
            Contrasena = Encriptar(TxtContrasena.Text),
            Correo = TxtCorreo.Text,
            Telefono = TxtTelefono.Text,
            CodigoRecuperación = new Random().Next(100,999),
            Direccion = null
        });
        Close();
    }

    private string Encriptar(string txt)
    {
        string hash = String.Empty;
        byte[] encriptado = SHA256.HashData(Encoding.UTF8.GetBytes(txt));
        foreach (byte b in encriptado)
        {
            hash += b.ToString("x2");
        }
        return hash;
    }
}