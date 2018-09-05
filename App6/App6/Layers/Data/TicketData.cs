using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Data
{
    public class TicketData
    {
        public TicketData()
        {

        }

        public List<TicketModel> GetList(){

            List<TicketModel> listaTickets = new List<TicketModel>();
             
            listaTickets.Add(new TicketModel(1, 50.0, "A23", "Evento#1", "Descrição#1"));
            listaTickets.Add(new TicketModel(2, 75.0, "F15", "Evento#2", "Descrição#2"));
            listaTickets.Add(new TicketModel(3, 150.0, "H17", "Evento#3", "Descrição#3"));


            return listaTickets;

        }
    }
}
