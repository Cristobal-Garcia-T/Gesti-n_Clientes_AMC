using System.ComponentModel;
using System.Windows;
using WPF.Windows.Formularios;

namespace WPF.Windows.Modals;

public partial class AdvertenciaSinAdmin
{
    public AdvertenciaSinAdmin()
    {
        InitializeComponent();
    }

    private void BtnCancelar_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnAceptar_OnClick(object sender, RoutedEventArgs e)
    {
        //Crea un diálogo con el forulario para registrar un administrador,
        //en caso de de que dicha operación sea cancelada cierra el programa
        DialogResult = new FormularioCrearAdmin().ShowDialog();
        Close();
    }
}