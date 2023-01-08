using System.Windows;

namespace GettingStarted;

public partial class Success : Window
{
    public Success()
    {
        InitializeComponent();
    }

    private void EndApp(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}