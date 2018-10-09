﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HGTAplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}