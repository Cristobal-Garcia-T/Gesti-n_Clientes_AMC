using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;
using Servicios;

namespace WPF.Windows.Formularios;

public partial class FormularioActualizarCliente : Window
{
    public FormularioActualizarCliente()
    {
        var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
        DataContext = new FormularioActualizarClienteViewModel(mensajero);
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