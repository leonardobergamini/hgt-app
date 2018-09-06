using System;

using App6.Models;

namespace App6.ViewModels
{
    public class ItemDetailViewModel
    {
        public TicketModel Ticket { get; set; }

        public ItemDetailViewModel(){
            Ticket = Models.Global.Ticket;
        }

    }


}
