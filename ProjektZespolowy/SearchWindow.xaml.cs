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
    /// Logika interakcji dla klasy SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {   
            InitializeComponent();
            items.Clear();
            items.Add("Pomidorowa");
            items.Add("Schabowy");
            items.Add("Jajecznica");
            lb_recipes.ItemsSource = items;
        }
        public static List<string> items = new List<string>();
        public static string name;

        private void back_b_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Main_Window window = new Main_Window();
            window.Show();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lb_recipes.ItemsSource).Refresh();
        }

        private void lb_recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           name = lb_recipes.SelectedItem.ToString();
            this.Close();
            RecipeShow recipe = new RecipeShow();
            recipe.Show();
        }
    }
}
