using System.Windows;

namespace GettingStarted;

public partial class Error : Window
{
    public Error()
    {
        InitializeComponent();
    }

    private void EndApp(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    
    
    private void ReturnRegistration(object sender, RoutedEventArgs e)
    {
        Registration registration = new Registration();
        registration.Show();
        this.Close();
    }
    
}