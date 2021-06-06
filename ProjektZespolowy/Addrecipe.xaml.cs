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
    /// Logika interakcji dla klasy Addrecipe.xaml
    /// </summary>
    public partial class Addrecipe : Window
    {
        public Addrecipe()
        {
            InitializeComponent();
        }
        string nazwa, elements, level, time, calories, category, content;
     
        private void b_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Main_Window mainwindow = new Main_Window();
            mainwindow.Show();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void b_acceptRecipe_Click(object sender, RoutedEventArgs e)
        {
            nazwa = tb_name.Text;
            elements = tb_elements.Text;
            level = tb_level.Text;
            time = tb_time.Text;
            calories = tb_calories.Text;
            category = tb_category.Text;
            content = tb_content.Text;
            if(nazwa!=null && elements!=null && level!=null&&time!=null&&calories!=null&&category!=null&&content!=null)
            {
                MessageBox.Show("Sukces");
                this.Close();
                Main_Window mainwindow = new Main_Window();
                mainwindow.Show();
            }
        }
    }
}
