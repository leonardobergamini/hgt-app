using System;
using App6.Models;

namespace App6.Layers.Services
{
    public class LocalServices
    {
        public LocalModel GetLocal(String _idLocal){
            var _local = new LocalModel();
            if (_idLocal.Equals("1")){
                _local = new LocalModel
                {
                    IdLocal = "1",
                    NomeLocal = "Local de Evento #1",
                    CapacidadeTotal = 20000,
                    Descricao = "Loca de Evento #1 ",
                    Endereco = "Rua Local de Evento #1",
                    NroEndereco = 1200,
                    ComplementoEndereco = "",
                    CEP = "12314-999",
                    Cidade = "São Paulo",
                    UF = "SP"

                };
            }
            if (_idLocal.Equals("2"))
            {
                _local = new LocalModel
                {
                    IdLocal = "2",
                    NomeLocal = "Local de Evento #2",
                    CapacidadeTotal = 40000,
                    Descricao = "Loca de Evento #2 ",
                    Endereco = "Rua Local de Evento #2",
                    NroEndereco = 876,
                    ComplementoEndereco = "Pŕoximo ao Metrô Paraiso",
                    CEP = "98756-000",
                    Cidade = "São Paulo",
                    UF = "SP"
                };
            }

            if (_idLocal.Equals("3"))
            {
                _local = new LocalModel
                {
                    IdLocal = "3",
                    NomeLocal = "Local de Evento #3",
                    CapacidadeTotal = 12000,
                    Descricao = "Local de Evento #3 ",
                    Endereco = "Rua Local de Evento #3",
                    NroEndereco = 316,
                    ComplementoEndereco = "Pŕoximo ao Metrô Santana",
                    CEP = "12309-000",
                    Cidade = "São Paulo",
                    UF = "SP"
                };
            }

            if (_idLocal.Equals("4"))
            {
                _local = new LocalModel
                {
                    IdLocal = "4",
                    NomeLocal = "Local de Evento #4",
                    CapacidadeTotal = 8000,
                    Descricao = "Local de Evento #4 ",
                    Endereco = "Rua Local de Evento #4",
                    NroEndereco = 316,
                    ComplementoEndereco = "Pŕoximo ao Metrô Jabaquara",
                    CEP = "97645-100",
                    Cidade = "São Paulo",
                    UF = "SP"
                };
            }

            return _local;
        }
    }
}
