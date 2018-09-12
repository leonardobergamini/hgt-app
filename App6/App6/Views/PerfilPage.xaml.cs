using System;
using System.Collections.Generic;
using App6.Layers.Business;
using App6.Layers.Data;
using App6.Models;
using App6.ViewModels;
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

        public void ClickedBotaoSair(Object o, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}