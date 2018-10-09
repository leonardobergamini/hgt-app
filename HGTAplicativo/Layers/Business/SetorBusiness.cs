using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class SetorBusiness
    {
        public SetorModel GetSetorById(String _idSetor)
        {
            var _setor = new SetorServices().GetSetorById(_idSetor);
            return _setor;
        }
    }
}
