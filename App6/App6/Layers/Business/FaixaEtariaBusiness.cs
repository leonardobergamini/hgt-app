using System;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class FaixaEtariaBusiness
    {
        public FaixaEtariaModel GetFaixaEtariaById(String _idFaixa){
            var _faixa = new FaixaEtariaServices().GetFaixaEtariaById(_idFaixa);
            return _faixa;
        }
    }
}
