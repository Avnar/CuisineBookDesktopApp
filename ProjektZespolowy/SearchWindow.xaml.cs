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
using System.Net.Http;
using Newtonsoft.Json;
using ProjektZespolowy.Klasy;


namespace ProjektZespolowy
{
    /// <summary>
    /// Logika interakcji dla klasy SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private int pageNumber = 2;

        public SearchWindow()
        {   
            InitializeComponent();
            tb_ingridients.Visibility = Visibility.Hidden;
            Pullrecipes();
        }
        public static string name;

         public async Task<Response> GetRequest(string url)
        {
            Response.Data.Clear();
            lb_recipes.Items.Clear();

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenContainer.Token);
            var httpResponse = await httpClient.GetAsync(url);
            var response = await httpResponse.Content.ReadAsStringAsync();

            var deserializedFood = JsonConvert.DeserializeObject<Response>(response);

            foreach (var food in Response.Data)
            {
                lb_recipes.Items.Add(food.ShowTitle());
            }

            return deserializedFood;
        }

        private void b_recipes_next_Click(object sender, RoutedEventArgs e)
        {
            if (pageNumber <= Response.TotalPages)
            {
                pageNumber++;
            }
            else if (pageNumber > Response.TotalPages)
            {
                pageNumber = 1;
            }
            Pullrecipes();
        }

        private void b_recipes_back_Click(object sender, RoutedEventArgs e)
        {
            if (pageNumber >= Response.TotalPages)
            {
                pageNumber--;
            }
            else if (pageNumber < Response.TotalPages)
            {
                pageNumber = 1;
            }
            Pullrecipes();

        }
        private async void Pullrecipes()
        {
            string url = "https://localhost:44314/api/Food/GetAccepted?PageNumber=";
            await GetRequest(url + pageNumber + "&isAccepted=false");
            //"https://localhost:44314/api/Food?PageNumber="
            //https://localhost:44314/api/Food/GetAccepted?isAccepted=true
            //https://localhost:44314/api/Food/GetAccepted?PageNumber=2&isAccepted=true

        }


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

        private void lb_recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void lb_recipes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var index = lb_recipes.SelectedIndex;
            var item = Response.Data[index];
            RecipeShow recipeShow = new RecipeShow(item);
            recipeShow.Show();
            this.Hide();
        }
    }
}
