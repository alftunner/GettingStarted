using System.Windows;

namespace GettingStarted;

public partial class Succes : Window
{
    public Succes()
    {
        InitializeComponent();
    }

    private void EndApp(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}