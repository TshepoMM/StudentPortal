using RestSharp;
using StudentMarks.Models;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentMarks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        bool connectionSuccesful;
        UserModel user = null;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, System.EventArgs e)
        {

            activity.IsVisible = true;
            activity.IsRunning = true;

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text))
            {
                DisplayAlert("Error", "Please fill in your details", "OK");
                activity.IsVisible = false;
                activity.IsRunning = false;
            }
            else
            {
                Task.Run(() =>
                {
                    UserModel user = GetUser();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (user != null)
                        {
                            if (user.Password == password.Text)
                                Application.Current.MainPage = new NavigationPage(new AboutPage(user));
                            else
                                DisplayAlert("Authentication Error", "Please enter the correct details", "Ok");
                        }
                        else
                        if (connectionSuccesful)
                            DisplayAlert("Authentication Error", "Please enter the correct details", "Ok");
                        else
                            DisplayAlert("Connection Error", "Please check your internet connection", "Ok");

                        activity.IsVisible = false;
                        activity.IsRunning = false;
                    });
                });
            }
        }
        private UserModel GetUser()
        {
            string reqAddress = "http://tlekhila78-001-site1.etempurl.com/api/login/signin?email=" + email.Text;
            var client = new RestClient(reqAddress);

            var request = new RestRequest();

            var response = client.Execute<UserModel>(request, Method.GET);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                connectionSuccesful = true;
                if (response.IsSuccessful)
                    user = response.Data;
            }
            //todo Decryption

            return user;
        }
    }
}