using System;
using App6.Models;

namespace App6.Layers.Services
{
    public class FormaPagamentoServices
    {
        public FormaPagamentoModel GetFormaPagamento(UsuarioModel _usuario){


            if(Global.Usuario.IdCliente.Equals("003f400000ZHEbGAAX")){
                var _cartao = new CartaoCreditoServices().GetCartaoCredito("1");
                var _formaPg = new FormaPagamentoModel
                {
                    IdFormaPagamento = "1",
                    Usuario = Global.Usuario,
                    CartaoCredito = _cartao
                };

                return _formaPg;
            }else if (Global.Usuario.IdCliente.Equals("003f400000ZHEbVAAX"))
            {
                var _cartao = new CartaoCreditoServices().GetCartaoCredito("2");
                var _formaPg = new FormaPagamentoModel
                {
                    IdFormaPagamento = "2",
                    Usuario = Global.Usuario,
                    CartaoCredito = _cartao
                };

                return _formaPg;
            }else{
                return null;
            }
        }

        public FormaPagamentoServices()
        {
        }
    }
}
