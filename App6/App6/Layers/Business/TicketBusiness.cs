using System;
using System.Collections.Generic;
using App6.Layers.Data;
using App6.Models;

namespace App6.Layers.Business
{
    public class TicketBusiness
    {
        public TicketBusiness(){}

        public List<TicketModel> GetList()
        {
            var ListaTickets = new TicketData().GetList();
            return ListaTickets;
        }
    }

}
