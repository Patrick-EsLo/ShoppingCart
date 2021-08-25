using ShoppingCart.Data;
using ShoppingCart.Model;
using ShoppingCart.Views;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShoppingCart
{
    public partial class App : Application
    {
        private static TokenDatabaseController tokenDatabase;
        private static UserDatabaseController userDatabase;
        private static RestService restService;
        private static Database database;

        //private static Label labelScreen;
        //private static bool hasInternet;
        //private static Page currentPage;
        //private static Timer timer;
        //private static bool noInterShow;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());//coloquei o ponto e virgula
           // {
               // BarBackgroundColor = (Color)Resources["NavBarBackgroundColor"],
             //   BarTextColor = (Color)Resources["NavBarTextColor"],
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        //}
        //}
        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }

                return userDatabase;
            }
        }

        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }

                return tokenDatabase;
            }
        }

        public static RestService RestService
        {
            get
            {
                if (restService == null)
                {
                    restService = new RestService();
                }

                return restService;
            }
        }

      //  public static Database Database
       // {
         //   get
           // {
             //   if (database == null)
               // {
                 //   database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
               // }

               // return database;
            //}
        //}

    }

       
}
