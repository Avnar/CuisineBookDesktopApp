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
    /// Logika interakcji dla klasy CaloriesCalculator.xaml
    /// </summary>
    public partial class CaloriesCalculator : Window
    {
        public CaloriesCalculator()
        {
            InitializeComponent();
        }

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Main_Window window = new Main_Window();
            window.Show();
        }
        List<string> values = new List<string>();

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void b_add_click(object sender, RoutedEventArgs e)
        {
            lb_summary.Items.Add(tb_value.Text + " kcal");
            values.Add(tb_value.Text);
            tb_value.Clear();
        }

        private void b_equals_Click(object sender, RoutedEventArgs e)
        {
            double total = values.Sum(x => Convert.ToInt32(x));
            tb_wynik.Text = total.ToString() + " kcal";
        }
    }
}
