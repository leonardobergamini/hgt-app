using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App6.ViewModels
{
    public class TitularidadeViewModel
    {
        public TitularidadeViewModel()
        {
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
