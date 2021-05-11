using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektZespolowy
{
    /// <summary>
    /// Logika interakcji dla klasy LoginRegisterWindow.xaml
    /// </summary>
    public partial class LoginRegisterWindow : Window
    {
        public LoginRegisterWindow()
        {
            InitializeComponent();
            sethidden();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Main_Window mainwindow = new Main_Window();
            mainwindow.Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            register_b.Visibility = Visibility.Hidden;
            login_b.Visibility = Visibility.Hidden;
            register_tb.Visibility = Visibility.Visible;
            registerUnderline.Visibility = Visibility.Visible;
            save_b.Visibility = Visibility.Visible;

        }

        private void LoginRegisterWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
             DragMove(); 
        }
        private void sethidden() 
        {
            save_b.Visibility = Visibility.Hidden;
            register_tb.Visibility = Visibility.Hidden;
            registerUnderline.Visibility = Visibility.Hidden;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            login_b.Visibility = Visibility.Visible;
            register_b.Visibility = Visibility.Visible;
            sethidden();

        }
    }
}
