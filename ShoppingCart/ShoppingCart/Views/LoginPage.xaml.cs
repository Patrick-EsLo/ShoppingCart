using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;

            ActivitySpinner.IsVisible = false;

            // var result = new Token();//Para testar é só descomentar essa linha

            LoginIcon1.HeightRequest = Constants.LoginIconHeight;

           // App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {
                Token token = await App.RestService.Login(user);

                if (token.access_token != null)
                {
                    //App.UserDatabase.SaveUser(user); - Comentar para testar
                    //App.TokenDatabase.SaveToken(token);- Comentar para testar

                    await DisplayAlert("Login", "Login Success", "Ok");
                    if (Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MainPage());
                    }
                    else if (Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
                    }
                    else
                    {
                        await Navigation.PushAsync(new MainPage()); // might not work for UWP
                    }
                }
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct, empty username or password.", "Ok");
            }
        }
    }
}