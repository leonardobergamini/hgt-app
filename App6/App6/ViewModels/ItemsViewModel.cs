using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using App6.Models;
using App6.Views;
using App6.Layers.Business;
using System.Collections;
using System.Collections.Generic;
using App6.Layers.Data;

namespace App6.ViewModels
{
    public class ItemsViewModel
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }


        public ItemsViewModel()
        {
            /*List<TicketModel> ListaTickets = new List<TicketModel>{
                new TicketModel(Id = 1, Preco = 50.0, Codigo = "A23", Nome = "Evento#1", Descricao = "Descrição#1"),
                new TicketModel(Id = 2, Preco = 75.0, Codigo = "F15", Nome = "Evento#2", Descricao = "Descrição#2"),
                new TicketModel(Id = 3, Preco = 150.0, Codigo = "H17", Nome = "Evento#3", Descricao = "Descrição#3")
            };*/

            var ListaTickets = new TicketBusiness().GetList();

        }
    }
}