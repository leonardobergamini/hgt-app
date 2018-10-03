using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App6.Layers.Business;
using App6.Models;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class TitularidadeViewModel
    {
        public ICommand AlterarClickedCommand { get; private set; }
        public TitularidadeViewModel()
        {
            AlterarClickedCommand = new Command(() =>
            {
                var _user = new UsuarioBusiness().GetUsuarioByCpf(CPF);

                if(_user != null){

                    //Consultar IdTitular por CPF
                    var _idTitular = new TitularTicketBusiness().GetIdTitularByCpf(_user.CPF);
                    if(_idTitular != null){
                        var _novoTitular = new TitularTicketModel()
                        {
                            IdTitular = _idTitular,
                            CPF = _user.CPF,
                            DtNascimento = new DateTime(int.Parse(_user.DtNascimento.Substring(0, 4)),
                                                    int.Parse(_user.DtNascimento.Substring(5, 2)),
                                                    int.Parse(_user.DtNascimento.Substring(8, 2))),
                            Email = _user.Email,
                            PrimeiroNome = _user.PrimeiroNome,
                            Sobrenome = _user.Sobrenome,
                            Telefone = _user.Telefone,
                            IdUsuario = _user.IdCliente
                        };

                        new TitularTicketBusiness().SetTitularTicket(Global.ItemPedido.IdItemPedido, _novoTitular);
                    }

                }
                else{
                    int i = 9;
                }

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string primeiroNome;
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set
            {
                if (primeiroNome != value)
                {
                    primeiroNome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string sobrenome;
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                if (sobrenome != value)
                {
                    sobrenome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string dtNascimento;
        public string DtNascimento
        {
            get
            {
                return dtNascimento;
            }
            set
            {
                if (dtNascimento != value)
                {
                    dtNascimento = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string cpf;
        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                if (cpf != value)
                {
                    cpf = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string telefone;
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (telefone != value)
                {
                    telefone = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
