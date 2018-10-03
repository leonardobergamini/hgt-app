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

        public void SetTitularTicket(String _idItem, TitularTicketModel _titularTicket)
        {
            new TitularTicketServices().SetTitularTicketAsync(_idItem, _titularTicket);
        }

        public String GetIdTitularByCpf(String _cpf){
            return new TitularTicketServices().GetIdTitularByCpf(_cpf);
        }
    }
}
