using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class PedidoServices
    {
        public List<PedidoModel> GetPedidoByUsuario(UsuarioModel _user, CartaoCreditoModel _cartao){

            List<PedidoModel> _listaPedidos = new List<PedidoModel>();
            var _formaPg = new FormaPagamentoServices().GetFormaPagamento(_user);
            var _cartaoPg = new CartaoCreditoServices().GetCartaoCredito(_formaPg.IdFormaPagamento);

            if(_user.NmUsuario.Equals("leonardo") && _formaPg.IdFormaPagamento.Equals("1")){

                var _pedido = new PedidoModel
                {
                    IdPedido = "P-0001",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };
                _listaPedidos.Add(_pedido);

                var _pedido2 = new PedidoModel
                {
                    IdPedido = "P-0002",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };
                _listaPedidos.Add(_pedido2);

                return _listaPedidos;

            }else if(_user.NmUsuario.Equals("matheus") && _formaPg.IdFormaPagamento.Equals("2")){
                var _pedido = new PedidoModel
                {
                    IdPedido = "P-0003",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };
                _listaPedidos.Add(_pedido);

                return _listaPedidos;
            }else{
                return null;
            }
        }

        public PedidoModel GetPedidoById(String _idPedido){

            PedidoModel _pedido = new PedidoModel();
            var _user = Global.Usuario;
            var _formaPg = new FormaPagamentoServices().GetFormaPagamento(Global.Usuario);
            var _cartaoPg = new CartaoCreditoServices().GetCartaoCredito(_formaPg.IdFormaPagamento);

            if (_idPedido.Equals("P-0001")){
                _pedido = new PedidoModel
                {
                    IdPedido = "P-0001",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };

            }
            if(_idPedido.Equals("P-0002")){
                _pedido = new PedidoModel
                {
                    IdPedido = "P-0002",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };
            }
            if(_idPedido.Equals("P-0003")){
                _pedido = new PedidoModel
                {
                    IdPedido = "P-0003",
                    Usuario = _user,
                    FormaPagamento = _formaPg
                };
            }

            return _pedido;
        }

    }
}
