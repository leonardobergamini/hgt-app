using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class SetorServices
    {
        public SetorModel GetSetor (String _idSetor){

            var _setor = new SetorModel();
            if (_idSetor.Equals("1"))
            {
                var _local = new LocalServices().GetLocal("1");
                _setor = new SetorModel
                {
                    IdSetor = "1",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A do Local #1",
                    CapacidadeTotalSetor = 20000,
                    CapacidadeUsadaSetor = 18500,
                    Local = _local
                };
            }
            if (_idSetor.Equals("2"))
            {
                var _local = new LocalServices().GetLocal("2");
                _setor = new SetorModel
                {
                    IdSetor = "2",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A do Local #2",
                    CapacidadeTotalSetor = 40000,
                    CapacidadeUsadaSetor = 39000,
                    Local = _local
                };
            }
            if (_idSetor.Equals("3"))
            {
                var _local = new LocalServices().GetLocal("3");
                _setor = new SetorModel
                {
                    IdSetor = "3",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A do Local #3",
                    CapacidadeTotalSetor = 12000,
                    CapacidadeUsadaSetor = 11500,
                    Local = _local
                };
            }

            if (_idSetor.Equals("4"))
            {
                var _local = new LocalServices().GetLocal("4");
                _setor = new SetorModel
                {
                    IdSetor = "4",
                    NomeSetor = "Setor A",
                    Descricao = "Descrição do Setor A do Local #4",
                    CapacidadeTotalSetor = 8000,
                    CapacidadeUsadaSetor = 7000,
                    Local = _local
                };
            }

            return _setor;

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

        public List<SetorModel> GetSetoresByIdLocal(String _idLocal){

            var _local = new LocalServices().GetLocal(_idLocal);
            var _setores = GetAllSetores();
            List<SetorModel> listaSetores = new List<SetorModel>();

            foreach (var setor in _setores)
            {
                if(setor.IdSetor.Equals(_idLocal)){
                    listaSetores.Add(new SetorModel(setor.IdSetor, setor.NomeSetor,
                                                    setor.Descricao, setor.CapacidadeTotalSetor,
                                                    setor.CapacidadeUsadaSetor, _local));
                }else{
                    return null;
                }
            }

            return listaSetores;

        }

    }
}
