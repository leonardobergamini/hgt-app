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

        public ItemsViewModel()
        {
            ListaEventos = new EventoBusiness().GetEventos();
            //ListaEventos = new TicketBusiness().GetAllTicketByUsuario(Global.Usuario);

        }
        private IList<EventoModel> listaEvento;
        public IList<EventoModel> ListaEventos{
            get{
                return listaEvento;
            }
            set{
                listaEvento = value;
            }
        }

    }
}