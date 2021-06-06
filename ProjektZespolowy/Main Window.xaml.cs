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
    /// Logika interakcji dla klasy Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        public Main_Window()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void addRecipe_b_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Addrecipe recipewindow = new Addrecipe();
            recipewindow.Show();
        }

        private void find_b_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchWindow window = new SearchWindow();
            window.Show();
        }

        private void exit_b_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void calculator_b_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CaloriesCalculator calculator = new CaloriesCalculator();
            calculator.Show();
        }
    }
}
