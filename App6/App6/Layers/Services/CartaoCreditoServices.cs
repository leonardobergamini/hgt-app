using System;
using System.Collections.Generic;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class CartaoCreditoServices
    {
        public CartaoCreditoModel GetCartaoCredito(UsuarioModel _usuario){

            return null;

            //if(_idFormaPagamento == "1"){
            //    var _cartao = new CartaoCreditoModel
            //    {
            //        IdCartao = 1,
            //        NomeTitular = "Leonardo Bergamini",
            //        NroCartao = "0987678965431234",
            //        CodSeguranca = 148,
            //        ValCartao = new DateTime(2022, 09, 01)
            //    };

            //    return _cartao;
            //}else if (_idFormaPagamento == "2")
            //{
            //    var _cartao = new CartaoCreditoModel
            //    {
            //        IdCartao = 2,
            //        NomeTitular = "Matheus Bergamini",
            //        NroCartao = "9834609875432454",
            //        CodSeguranca = 228,
            //        ValCartao = new DateTime(2027, 10, 01)
            //    };
            //    return _cartao;
            //}else{
            //    return null;
            //}
        }

        public CartaoCreditoServices()
        {
        }
    }
}
