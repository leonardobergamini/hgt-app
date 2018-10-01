using System;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
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
