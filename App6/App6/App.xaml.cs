using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App6.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<string>("", "LoginSucesso", (sender) =>
            {
                MainPage = new NavigationPage(new MainPage());
            });
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void MensagemAlerta(string texto)
        {
            App.Current.MainPage.DisplayAlert("Alerta", texto, "OK");
        }

    }
}
