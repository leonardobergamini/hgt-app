using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class TicketBusiness
    {
        public TicketModel GetTicketByIdItem(String _idItem)
        {

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
