﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App6.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


        }

        async void ClickedBotaoEntrar(Object o, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
