using System.Windows;
using ControladoresWPF;
using Microsoft.Extensions.DependencyInjection;
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
        var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
        var codigoRecuperacion = new TablaUsuariosViewModel(servicio).AgregarAdministrador(
        [
            TxtRut.Text,
            TxtNombres.Text,
            TxtApellidos.Text,
            TxtContrasena.Text,
            TxtCorreo.Text,
            TxtTelefono.Text
        ]
        );
        new AvisoCodigoRecuperacion(codigoRecuperacion).ShowDialog();
        Close();
    }
}