using System;
using System.Collections.Generic;
using App6.Layers.Data;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class TicketBusiness
    {
        public TicketModel GetTicketByIdItem(String _idItem){

            var _ticket = new TicketServices().GetTicketByIdItem(_idItem);

            return _ticket;
        }

        public TicketModel GetTicketById(String _idTicket)
        {

            TicketModel _ticket = new TicketServices().GetTicketById(_idTicket);

            return _ticket;
        }
    }

}
