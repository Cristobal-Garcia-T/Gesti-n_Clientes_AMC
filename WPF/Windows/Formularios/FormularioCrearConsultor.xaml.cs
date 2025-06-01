using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows.Formularios;

public partial class FormularioCrearConsultor
{
    public FormularioCrearConsultor()
    {
        var servicio = App.AppHost.Services.GetRequiredService<ServicioConsultores>();
        var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
        DataContext = new FormularioCrearConsultorViewModel(servicio, mensajero);
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