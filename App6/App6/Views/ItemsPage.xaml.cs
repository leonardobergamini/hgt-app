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
using App6.Layers.Business;
using App6.Layers.Data;

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
            InitializeComponent();
            ItemsListView.ItemTapped += async (sender, e) =>
            {
                if (e.Item == null)
                    return;
                Global.Evento = (EventoModel) e.Item;
                await Navigation.PushAsync(new ItemDetailPage());
            };

            
        }
    }
}
