using System;
using System.Collections.Generic;
using App6.Models;
using Xamarin.Forms;

namespace App6.Views
{
    public partial class ItensDetailPage : ContentPage
    {
        public ItensDetailPage()
        {
            InitializeComponent();
            ItensListView.ItemTapped += async (sender, e) =>
            {
                if (e.Item == null)
                    return;
                Global.ItemPedido = (ItemPedidoModel)e.Item;
                await Navigation.PushAsync(new ItemDetailPage());
            };
        }
    }
}
