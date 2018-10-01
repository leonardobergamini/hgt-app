using System;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class FormaPagamentoBusiness
    {
        public FormaPagamentoModel GetFormaPagamento(UsuarioModel _usuario)
        {
            var _forma = new FormaPagamentoServices().GetFormaPagamento(Global.Usuario);
            return _forma;
        }
    }
}
