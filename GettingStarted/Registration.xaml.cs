using System.Windows;
using System.Windows.Controls;

namespace GettingStarted;

public partial class Registration : Window
{
    public Registration()
    {
        InitializeComponent();
    }

    private void RegistrationNewUsers(object sender, RoutedEventArgs e)
    {
        
        UserTable userTable = new UserTable();
        if (!userTable.compareLoginPassword(loginBox.Text, passwordBox.Password))
        {
            userTable.registrationUsers(loginBox.Text, passwordBox.Password);
            Succes succes = new Succes();
            succes.Show();
        }
        else
        {
            Error error = new Error();
            error.Show();
        }
        this.Close();
    }
}