using System.ComponentModel;
using System.Windows;

namespace WPF.Windows;

public partial class AdvertenciaSinAdmin : Window
{
    public AdvertenciaSinAdmin()
    {
        InitializeComponent();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        var resultado = new FormularioCrearAdmin().ShowDialog();
        if ((bool)resultado!)
            Close();
        Application.Current.Shutdown();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        Application.Current.Shutdown();
    }
}