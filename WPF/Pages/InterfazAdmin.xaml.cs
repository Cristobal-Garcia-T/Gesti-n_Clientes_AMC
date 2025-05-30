using System.Windows;
using System.Windows.Controls;

namespace WPF.Pages;

public partial class InterfazAdmin : Page
{
    public InterfazAdmin()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        NavigationService!.GoBack();
    }
}