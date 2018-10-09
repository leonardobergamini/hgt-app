using System;
using System.Collections.Generic;
using HGTAplicativo.Models;
using HGTAplicativo.Layers.Business;

using Xamarin.Forms;

namespace HGTAplicativo.Views
{
    public partial class ItensPage : ContentPage
    {
        public ItensPage()
        {
            InitializeComponent();

            ItensListView.ItemTapped += async (sender, e) =>
            {
                if (e.Item == null)
                    return;
                Global.Pedido = (PedidoModel) e.Item;
                Global.ItensPedidos = new ItemPedidoBusiness().GetAllItemPedido(Global.Pedido.IdPedido);

                if(Global.ItensPedidos.Count > 1){
                    await Navigation.PushAsync(new ItensDetailPage());
                }else if(Global.ItensPedidos.Count == 1){
                    //Pegar o IdItem do Ticket
                    Global.ItemPedido = new ItemPedidoBusiness().GetItemPedidoById(Global.ItensPedidos[0].IdItemPedido);
                    //Global.Ticket = new TicketBusiness().GetTicket(Global.Pedido.IdPedido, Global.ItemPedido.IdItemPedido);
                    await Navigation.PushAsync(new ItemDetailPage());
                }else{
                    throw new Exception("Erro na página de ItemsPage()");
                }

            };
        }
    }
}
