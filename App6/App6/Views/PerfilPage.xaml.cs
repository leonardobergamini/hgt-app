using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();

        }

        async void ClickedBotaoSair(Object o, EventArgs e)
        {

            await Navigation.PushAsync(new LoginPage());
        }
    }
}