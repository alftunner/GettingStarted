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
        if (loginBox.Text == "" || passwordBox.Password == "")
        {
            MessageBox.Show("Заполните все поля");
        }
        else if (!userTable.compareLoginPassword(loginBox.Text, passwordBox.Password))
        {
            userTable.registrationUsers(loginBox.Text, passwordBox.Password);
            Success succes = new Success();
            succes.Show();
            this.Close();
        }
        else
        {
            Error error = new Error();
            error.Show();
            this.Close();
        }
        
    }
}