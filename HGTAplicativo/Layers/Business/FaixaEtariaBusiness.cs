using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class FaixaEtariaBusiness
    {
        public FaixaEtariaModel GetFaixaEtariaById(String _idFaixa)
        {
            var _faixa = new FaixaEtariaServices().GetFaixaEtariaById(_idFaixa);
            return _faixa;
        }
    }
}
