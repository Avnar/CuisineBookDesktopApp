using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ProjektZespolowy.Klasy;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;

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
            password_tb.Text = "";
            usernameTb.Text = "";
            lb_email.Visibility = Visibility.Hidden;
        }
       private readonly HttpClient _httpClient = new HttpClient();
        public async Task<string> LoginAsync(string url)
        {
            var login = new Dictionary<string, object>
            {
                {"username",usernameTb.Text},
               
                {"password",password_tb.Text}
            };

            string payloadFood = JsonConvert.SerializeObject(login);
            var httpContent = new StringContent(payloadFood, Encoding.UTF8, "application/json");
            var httpResponse = await _httpClient.PostAsync(url, httpContent);
            string status = (httpResponse.StatusCode == HttpStatusCode.Created).ToString();
            var response = await httpResponse.Content.ReadAsStringAsync();

            switch (httpResponse.StatusCode) {
                case HttpStatusCode.OK:
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(response);
                    TokenContainer.Token = loginResponse.Token;
                    Main_Window mainwindow = new Main_Window();
                    mainwindow.Show();
                    this.Close();
                    break;
                case HttpStatusCode.Unauthorized:
                    MessageBox.Show("Nieprawidłowe dane");
                    
                    break;
            }

            return response;
        }
        public async Task<string> RegisterAsync(string url)
        {
            var register = new Dictionary<string, object>
            {
                {"username",usernameTb.Text},
                {"email",register_tb.Text},
                {"password",password_tb.Text}
            };
            string payloadFood = JsonConvert.SerializeObject(register);
            var httpContent = new StringContent(payloadFood, Encoding.UTF8, "application/json");

            var httpResponse = await _httpClient.PostAsync(url, httpContent);
            var response = await httpResponse.Content.ReadAsStringAsync();

            switch (httpResponse.StatusCode)
            {
                case HttpStatusCode.OK:
                    login_b.Visibility = Visibility.Visible;
                    register_b.Visibility = Visibility.Visible;
                    sethidden();
                    break;
                case HttpStatusCode.InternalServerError:
                    MessageBox.Show("Błąd rejestracji");
                    break;

            }
            return response;
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            await LoginAsync("https://localhost:44314/api/Identity/Login");
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            lb_email.Visibility = Visibility.Visible;
            register_b.Visibility = Visibility.Hidden;
            login_b.Visibility = Visibility.Hidden;
            register_tb.Visibility = Visibility.Visible;
            registerUnderline.Visibility = Visibility.Visible;
            save_b.Visibility = Visibility.Visible;
            register_tb.Text = "";

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

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            await RegisterAsync("https://localhost:44314/api/Identity/Register");
            lb_email.Visibility = Visibility.Hidden;
        }

        private void b_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
