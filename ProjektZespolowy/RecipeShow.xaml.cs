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
    /// Logika interakcji dla klasy RecipeShow.xaml
    /// </summary>
    public partial class RecipeShow : Window
    {
        public RecipeShow()
        {
            InitializeComponent();
            GettingData();
        }
        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();

        }
        private void GettingData()
        {
            if(SearchWindow.name=="Pomidorowa")
            {
                lb_name.Content = "Zupa Pomidorowa";
                lb_category.Content = "Zupa";
                tb_items.Text = "Pomidor, Śmietana, Sól, Pieprz, Woda";
                lb_lvl.Content = "Średni";
                lb_time.Content = "90min";
                lb_calories.Content = "400"+" kcal";
                tb_content.Text = "Przygotuj litrowy garnek potem dodaj składniki i gotowe.";
            }
            else if(SearchWindow.name == "Schabowy")
            {
                lb_name.Content = "Kotlet Schabowy";
                lb_category.Content = "Danie Mięsne";
                tb_items.Text = "Pierś z kurczaka, ziemniaki, mąka, jajka";
                lb_lvl.Content = "Łatwy";
                lb_time.Content = "30min";
                lb_calories.Content = "700" + " kcal";
                tb_content.Text = "Mięso umyj potem pokrój i smaż";
            }
            else if(SearchWindow.name == "Jajecznica")
            {
                lb_name.Content = "Jajecznica";
                lb_category.Content = "Danie Mięsne";
                tb_items.Text = "Jajka, masło, sól, pieprz";
                lb_lvl.Content = "Łatwy";
                lb_time.Content = "5min";
                lb_calories.Content = "300" + " kcal";
                tb_content.Text = "Rozgrzej masło na patelni wbij jajka smaż przez 4 min i wgl to dodaj jeszcze trochę soli i pieprzu";
            }



        }
           
    }
}
