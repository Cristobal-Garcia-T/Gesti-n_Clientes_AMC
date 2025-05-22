using System.ComponentModel;
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
        //Registra la respusta del usuario
        DialogResult = false;
        Close();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        //Registra la respuesta del usuario
        DialogResult = true;
        //Recupera los campos de texto de la UI y crea una lista con os atributos
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
        //Genera un dialogo mostrado el código de recuperación asignado a la cuenta creada
        new AvisoCodigoRecuperacion(codigoRecuperacion).ShowDialog();
        Close();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        //En caso de que la ventana sea cerrada devuelve una respuesta negativa
        DialogResult = false;
        base.OnClosing(e);
    }
}