using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using HGTAplicativo.Models;

using Xamarin.Forms;

namespace HGTAplicativo.Views
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

                using(UserDialogs.Instance.Loading("Carregando ingresso...")){
                    await Task.Run(() =>
                    {
                        var _item = (ItemPedidoModel)e.Item;
                        Global.ItemPedido = _item.ItemPedido;
                    });

                    await Navigation.PushAsync(new ItemDetailPage());
                }

            };
        }
    }
}
