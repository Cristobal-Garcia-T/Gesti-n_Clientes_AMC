using System.Windows;
using System.Windows.Controls;

namespace WPF.Pages;

public partial class InterfazConsultor : Page
{
    public InterfazConsultor()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        NavigationService!.GoBack();
    }
}