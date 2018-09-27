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

namespace App6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
                //Global.Index = (ItensListView.ItemsSource as List<ExibicaoPedido>).IndexOf(Global.ExibicaoPedido);
                //Global.Pedido = Global.ExibicaoPedido.Pedidos[Global.Index];
                Global.ItensPedidos = new ItemPedidoBusiness().GetAllItemPedido(Global.Pedido);

                if(Global.ItensPedidos.Count > 1){
                    await Navigation.PushAsync(new ItensDetailPage());
                }else if(Global.ItensPedidos.Count == 1){
                    //Pegar o IdItem do Ticket
                    Global.ItemPedido = new ItemPedidoBusiness().GetItemPedidoById(Global.ItensPedidos[0].IdItemPedido);
                    Global.Ticket = new TicketBusiness().GetTicket(Global.Pedido.IdPedido, Global.ItemPedido.IdItemPedido);
                    await Navigation.PushAsync(new ItemDetailPage());
                }else{
                    throw new Exception("Erro na página de ItemsPage()");
                }

            };

            
        }
    }
}
