using System;
using App6.Models;

namespace App6.Layers.Services
{
    public class EventoServices
    {
        public EventoModel GetEventoByLocal(String _idLocal){

            var _evento = new EventoModel();

            if (_idLocal.Equals("1")){
                _evento = new EventoModel
                {
                    IdEvento = "1",
                    NomeEvento = "KASABIAN",
                    Descricao = "Depois de três anos de espera o grupo britânico " +
                        "está de volta ao Brasil para mais uma apresentação.",
                    DtInicioEvento = new DateTime(2018, 09, 19),
                    DtFinalEvento = new DateTime(2018, 09, 19),
                    DtInicioVenda = new DateTime(2018, 08, 01),
                    DtFinalVenda = new DateTime(2018, 09, 10),
                    UrlImagem = "kasabian.jpg",
                    FaixaEtaria = new FaixaEtariaServices().GetFaixaEtaria("1"),
                    Local = new LocalServices().GetLocal("1")
                };
            }
            if(_idLocal.Equals("2")){
                _evento = new EventoModel
                {
                    IdEvento = "2",
                    NomeEvento = "ROGER WATERS",
                    Descricao = "Roger Waters retorna à América do Sul em 2018 com " +
                        "uma nova turnê, Roger Waters - Us + Them, que combina " +
                        "clássicos do Pink Floyd e novas canções de seu trabalho solo.",
                    DtInicioEvento = new DateTime(2018, 12, 19),
                    DtFinalEvento = new DateTime(2018, 12, 22),
                    DtInicioVenda = new DateTime(2018, 10, 01),
                    DtFinalVenda = new DateTime(2018, 12, 10),
                    UrlImagem = "rogerWaters.jpg",
                    FaixaEtaria = new FaixaEtariaServices().GetFaixaEtaria("2"),
                    Local = new LocalServices().GetLocal("2")
                };
            }
            if(_idLocal.Equals("3")){
                _evento = new EventoModel
                {
                    IdEvento = "3",
                    NomeEvento = "SKANK",
                    Descricao = "Skank apresenta o show do inédito DVD “OS Três " +
                        "Primeiros – Ao Vivo”. O repertório reúne os sucessos dos " +
                        "três primeiros álbuns.",
                    DtInicioEvento = new DateTime(2018, 09, 30),
                    DtFinalEvento = new DateTime(2018, 10, 01),
                    DtInicioVenda = new DateTime(2018, 04, 01),
                    DtFinalVenda = new DateTime(2018, 05, 10),
                    UrlImagem = "skank.jpg",
                    FaixaEtaria = new FaixaEtariaServices().GetFaixaEtaria("1"),
                    Local = new LocalServices().GetLocal("3")
                };
            }
            if(_idLocal.Equals("4")){
                _evento = new EventoModel
                {
                    IdEvento = "4",
                    NomeEvento = "LULU SANTOS",
                    Descricao = "Lulu Santos apresenta sua turnê “Canta Lulu”," +
                        " em comemoração aos seus 45 anos de carreira.",
                    DtInicioEvento = new DateTime(2018, 06, 19),
                    DtFinalEvento = new DateTime(2018, 06, 19),
                    DtInicioVenda = new DateTime(2018, 05, 01),
                    DtFinalVenda = new DateTime(2018, 05, 10),
                    UrlImagem = "luluSantos.jpg",
                    FaixaEtaria = new FaixaEtariaServices().GetFaixaEtaria("1"),
                    Local = new LocalServices().GetLocal("4")
                };
            }
            return _evento;
        }
    }
}
