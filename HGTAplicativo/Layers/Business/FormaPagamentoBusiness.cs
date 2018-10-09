using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
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
