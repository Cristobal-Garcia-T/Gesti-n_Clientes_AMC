using System.Windows;

namespace WPF.Windows;

public partial class AvisoCodigoRecuperacion : Window
{
    public AvisoCodigoRecuperacion(int codigoRecuperacion)
    {
        InitializeComponent();
        Label.Content = $"Su código de recuperación de cuenta es \"{codigoRecuperacion}\", no lo pierda";
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}