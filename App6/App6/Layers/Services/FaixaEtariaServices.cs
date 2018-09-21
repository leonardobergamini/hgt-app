using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class FaixaEtariaServices
    {

        public FaixaEtariaModel GetFaixaEtaria(String _id){

            if(_id.Equals("1")){
                var _faixaEtaria = new FaixaEtariaModel
                {
                    IdFaixaEtaria = "1",
                    NomeFaixaEtaria = "12 anos",
                    Descricao = "Contém algumas coisas."
                };
                return _faixaEtaria;
            }else if(_id.Equals("2")){
                var _faixaEtaria = new FaixaEtariaModel
                {
                    IdFaixaEtaria = "2",
                    NomeFaixaEtaria = "18 anos",
                    Descricao = "Contém algumas coisas proibidas para menores."
                };
                return _faixaEtaria;
            }else{
                return null;
            }

        }

        public FaixaEtariaServices(){

        }

    }
}
