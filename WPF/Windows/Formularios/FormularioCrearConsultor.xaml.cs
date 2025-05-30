using System.Windows;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows.Formularios;

public partial class FormularioCrearConsultor
{
    public FormularioCrearConsultor()
    {
        var servicio = App.AppHost.Services.GetRequiredService<ServicioConsultores>();
        DataContext = new FormularioCrearConsultorViewModel(servicio);
        InitializeComponent();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}