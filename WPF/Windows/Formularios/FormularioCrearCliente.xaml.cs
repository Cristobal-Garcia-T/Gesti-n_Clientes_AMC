using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Windows.Formularios;
using Microsoft.Extensions.DependencyInjection;

namespace WPF.Windows.Formularios;

public partial class FormularioCrearCliente : Window
{
    public FormularioCrearCliente()
    {
        var mensajero = App.AppHost.Services.GetRequiredService<IMessenger>();
        DataContext =  new FormularioCrearClienteViewModel(mensajero);
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