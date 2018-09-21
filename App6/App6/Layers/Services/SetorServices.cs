using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class SetorServices
    {
        public SetorModel GetSetor (String _id){
            if (_id.Equals("1"))
            {
                var _local = new LocalServices().GetLocal("1");
                var _setor = new SetorModel
                {
                    IdSetor = "1",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A",
                    CapacidadeTotalSetor = 10500,
                    CapacidadeUsadaSetor = 10500,
                    Local = _local
                };
                return _setor;
            }
            if (_id.Equals("2"))
            {
                var _local = new LocalServices().GetLocal("1");
                var _setor = new SetorModel
                {
                    IdSetor = "2",
                    NomeSetor = "Setor B",
                    Descricao = "Descrição do Setor B",
                    CapacidadeTotalSetor = 9500,
                    CapacidadeUsadaSetor = 8500,
                    Local = _local
                };
                return _setor;
            }
            if (_id.Equals("3"))
            {
                var _local = new LocalServices().GetLocal("3");
                var _setor = new SetorModel
                {
                    IdSetor = "3",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A",
                    CapacidadeTotalSetor = 40000,
                    CapacidadeUsadaSetor = 38500,
                    Local = _local
                };
                return _setor;
            }else{
                return null;
            }

        }


        public List<SetorModel> GetAllSetores(){
            List<SetorModel> _listaSetores = new List<SetorModel>();

            var _local = new LocalServices().GetLocal("1");
            SetorModel _setor = new SetorModel
            {
                IdSetor = "1",
                NomeSetor = "Setor A",
                Descricao = "Descrição do Setor A",
                CapacidadeTotalSetor = 10500,
                CapacidadeUsadaSetor = 10500,
                Local = _local
            };
            _listaSetores.Add(_setor);

            var _local1 = new LocalServices().GetLocal("1");
            SetorModel _setor1 = new SetorModel
            {
                IdSetor = "2",
                NomeSetor = "Setor B",
                Descricao = "Descrição do Setor B",
                CapacidadeTotalSetor = 9500,
                CapacidadeUsadaSetor = 8500,
                Local = _local
            };
            _listaSetores.Add(_setor1);

            var _local2 = new LocalServices().GetLocal("1");
            var _setor3 = new SetorModel
            {
                IdSetor = "3",
                NomeSetor = "Setor A",
                Descricao = "Descrição do Setor A",
                CapacidadeTotalSetor = 40000,
                CapacidadeUsadaSetor = 38500,
                Local = _local
            };
            _listaSetores.Add(_setor3);

            return _listaSetores;

        }

        public List<SetorModel> GetSetoresByIdLocal(String _id){

            var _local = new LocalServices().GetLocal(_id);
            var _setores = GetAllSetores();
            List<SetorModel> listaSetores = new List<SetorModel>();

            foreach (var setor in _setores)
            {
                if(setor.IdSetor.Equals(_id)){
                    listaSetores.Add(new SetorModel(setor.IdSetor, setor.NomeSetor,
                                                    setor.Descricao, setor.CapacidadeTotalSetor,
                                                    setor.CapacidadeUsadaSetor, _local));
                }else{
                    return null;
                }
            }

            return listaSetores;

        }

        public SetorServices()
        {
        }
    }
}
