using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HGTAplicativo.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HGTAplicativo
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
                System.Diagnostics.Debug.Print("Flavio 4" + DateTime.Now);
                MainPage = new NavigationPage(new MainPage());
                System.Diagnostics.Debug.Print("Flavio 5" + DateTime.Now);
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

        public static void MensagemAlerta(String texto){
            App.Current.MainPage.DisplayAlert("Alerta", texto, "OK");
        }
    }
}
