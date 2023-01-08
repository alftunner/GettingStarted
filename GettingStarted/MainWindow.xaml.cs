using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Authorize(object sender, RoutedEventArgs e)
        {
            UserTable users = new UserTable();
            if (users.compareLoginPassword(loginBox.Text, passwordBox.Password))
            {
                Congratulations congratulations = new Congratulations();
                congratulations.Show();
            }
            else
            {
                Choice_action choiceAction = new Choice_action();
                choiceAction.Show();
            }
            this.Close();
        }

        private void UIElement_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        { 
            UserTable users = new UserTable();
            
            if(users.compareLoginPassword(loginBox.Text, passwordBox.Password))
            {
                
                TextBlock1.Text = "+";
            }
            else
            {
                TextBlock1.Text = String.Empty;
                TextBlock1.Text += "-";
            }
        }
    }
}