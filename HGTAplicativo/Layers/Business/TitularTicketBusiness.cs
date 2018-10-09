using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class TitularTicketBusiness
    {
        public TitularTicketModel GetTitularTicketById(String _idTitular)
        {
            var _titular = new TitularTicketServices().GetTitularTicketById(_idTitular);
            return _titular;
        }

        public String GetIdTitularByCpf(String _cpf)
        {
            return new TitularTicketServices().GetIdTitularByCpf(_cpf);
        }
    }
}
