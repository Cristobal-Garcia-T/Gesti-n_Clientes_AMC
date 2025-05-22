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
        //Cierra el programa en caso de que el usuario deciad no registrar un administrador
        Application.Current.Shutdown();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        //Crea un diálogo con el forulario para registrar un administrador,
        //en caso de de que dicha operación sea cancelada cierra el programa
        var resultado = new FormularioCrearAdmin().ShowDialog();
        if ((bool)resultado!)
            Close();
        Application.Current.Shutdown();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        //Termina el programa en caso de que la ventana sea cerrada
        base.OnClosing(e);
        Application.Current.Shutdown();
    }
}