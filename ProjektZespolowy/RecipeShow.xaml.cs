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
using ProjektZespolowy.Klasy;

namespace ProjektZespolowy
{
    /// <summary>
    /// Logika interakcji dla klasy RecipeShow.xaml
    /// </summary>
    public partial class RecipeShow : Window
    {
        private Food _food;
        public RecipeShow(Food food)
        {
            InitializeComponent();
            _food = food;
            GettingData();
        }

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();

        }
        public void GettingData()
        {
            lb_name.Content = _food.Title;
            lb_category.Content = _food.Cathegory;
            lb_lvl.Content = _food.Difficulty;
            lb_time.Content = _food.PreparationTime;
            lb_calories.Content = _food.CalorificValue;
            tb_items.Text = _food.Ingredients;
            tb_content.Text = _food.PreparingMethod;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
        }
    }
}
