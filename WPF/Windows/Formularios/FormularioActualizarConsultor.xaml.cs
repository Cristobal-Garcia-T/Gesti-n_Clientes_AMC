using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows.Formularios;

public partial class FormularioActualizarConsultor : Window
{
    public FormularioActualizarConsultor()
    {
        var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
        DataContext = new FormularioActualizarConsultorViewModel(mensajero);
        InitializeComponent();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}