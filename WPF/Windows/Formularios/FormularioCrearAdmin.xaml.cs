using System.Windows;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows.Formularios;

public partial class FormularioCrearAdmin
{
    public FormularioCrearAdmin()
    {
        var servicio = App.AppHost.Services.GetRequiredService<ServicioAdministradores>();
        DataContext = new FormularioCrearAdminViewModel(servicio);
        InitializeComponent();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        //Registra la respuesta del usuario
        DialogResult = true;
        Close();
    }
}