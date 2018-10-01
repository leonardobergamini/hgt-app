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
                var _item = (ItemPedidoModel)e.Item;
                Global.ItemPedido = _item.ItemPedido;
                int i = 0;
                await Navigation.PushAsync(new ItemDetailPage());
            };
        }
    }
}
