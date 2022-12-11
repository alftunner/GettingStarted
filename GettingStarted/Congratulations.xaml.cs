using System.Windows;

namespace GettingStarted;

public partial class Congratulations : Window
{
    public Congratulations()
    {
        InitializeComponent();
    }

    private void CloseWindow(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}