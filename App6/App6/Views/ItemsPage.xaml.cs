using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App6.Models;
using App6.Views;
using App6.ViewModels;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {


        public ItemsPage()
        {
            InitializeComponent();



        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}