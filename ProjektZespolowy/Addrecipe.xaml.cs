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
using Newtonsoft.Json;
using System.Net.Http;


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

        public async Task<string> PostRequest(string url)
        {
            Food food = new Food
            {
                Title = tb_name.Text,
                Ingredients = tb_elements.Text,
                Difficulty = tb_level.Text,
                PreparationTime = tb_time.Text,
                CalorificValue = int.Parse(tb_calories.Text),
                PreparingMethod = tb_content.Text,
                Cathegory = tb_category.Text
            };

            string payloadFood = JsonConvert.SerializeObject(food);
            var httpContent = new StringContent(payloadFood, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenContainer.Token);
            var httpResponse = await httpClient.PostAsync(url, httpContent);
            var response = "";

            if (httpResponse.Content != null)
            {
                response = await httpResponse.Content.ReadAsStringAsync();
            }

           MessageBox.Show("Sukces !");
            Food deserializedFood = JsonConvert.DeserializeObject<Food>(payloadFood);
           // MessageBox.Show(deserializedFood.ToString());
            return response;
        }

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

        private async void b_acceptRecipe_Click(object sender, RoutedEventArgs e)
        {
            await PostRequest(Endpoints.POSTapiFood);
        }
    }
}
