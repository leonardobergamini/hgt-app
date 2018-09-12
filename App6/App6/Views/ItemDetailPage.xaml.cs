using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App6.Models;
using App6.ViewModels;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {

        public ItemDetailPage()
        {
            InitializeComponent();

        }

        async void AlterarClickedButton(Object o, EventArgs e){
            await Navigation.PushAsync(new TitularidadePage());
        }


    }
}