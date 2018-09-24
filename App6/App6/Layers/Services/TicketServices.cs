using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App6.Models;

namespace App6.Layers.Services
{
    public class TicketServices
    {
        public TicketModel GetTickets(String _idItem, String _idPedido){

            TicketModel _tickets = new TicketModel();

            if(_idItem.Equals("1") && _idPedido.Equals("P-0001")){
                var _setor = new SetorServices().GetSetor("1");
                var _ticket = new TicketModel()
                {
                    IdTicket = "1",
                    CodIngresso = "A21",
                    Preco = 75.0,
                    UrlQrCode = "qr_code.png",
                    Setor = _setor
                };
                _tickets = _ticket;
            }
            if (_idItem.Equals("2") && _idPedido.Equals("P-0002"))
            {
                var _setor = new SetorServices().GetSetor("2");
                var _ticket = new TicketModel()
                {
                    IdTicket = "2",
                    CodIngresso = "B11",
                    Preco = 195.0,
                    UrlQrCode = "qr_code.png",
                    Setor = _setor
                };
                _tickets = _ticket;
            }
            if (_idItem.Equals("3") && _idPedido.Equals("P-0003"))
            {
                var _setor = new SetorServices().GetSetor("3");
                var _ticket = new TicketModel()
                {

                    IdTicket = "3",
                    CodIngresso = "A03",
                    Preco = 1395.0,
                    UrlQrCode = "qr_code.png",
                    Setor = _setor
                };
                _tickets = _ticket;
            }
            if(_idItem.Equals("4") && _idPedido.Equals("P-0002")){
                var _setor = new SetorServices().GetSetor("1");
                var _ticket = new TicketModel()
                {

                    IdTicket = "4",
                    CodIngresso = "A45",
                    Preco = 75.0,
                    UrlQrCode = "qr_code.png",
                    Setor = _setor
                };
                _tickets = _ticket;
            }
            if(_idItem.Equals("5") && _idPedido.Equals("P-0001")){
                var _setor = new SetorServices().GetSetor("3");
                var _ticket = new TicketModel()
                {

                    IdTicket = "5",
                    CodIngresso = "B31",
                    Preco = 135.0,
                    UrlQrCode = "qr_code.png",
                    Setor = _setor
                };
                _tickets = _ticket;
            }

            return _tickets;
        }

  
    }
}