using System;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class TitularTicketBusiness
    {
        public TitularTicketModel GetTitularTicketById(String _idTitular){
            var _titular = new TitularTicketServices().GetTitularTicketById(_idTitular);
            return _titular;
        }
    }
}
