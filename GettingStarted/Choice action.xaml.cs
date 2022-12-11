using System.Windows;

namespace GettingStarted;

public partial class Choice_action : Window
{
    public Choice_action()
    {
        InitializeComponent();
    }

    private void AgainAutorization(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }

    private void RegistrationUsers(object sender, RoutedEventArgs e)
    {
        Registration registration = new Registration();
        registration.Show();
        this.Close();
    }
}