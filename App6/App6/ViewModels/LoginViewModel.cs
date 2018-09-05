using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App6.Layers.Business;
using App6.Models;
using Xamarin.Forms;

namespace App6.ViewModels
{

    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand EntrarClickedCommand { get; private set; }

        public LoginViewModel()
        {
            EntrarClickedCommand = new Command(() => {
                try
                {
                    var usuario = new UsuarioBusiness().Login(Usuario.ToLower(), Senha);
                    //App.MensagemAlerta("Nome do usuário: " + usuario.Nome);
                    Global.Usuario = usuario;
                    MessagingCenter.Send<string>("", "LoginSucesso");
                }
                catch (Exception e)
                {
                    App.MensagemAlerta(e.Message);
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string senha;
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                if (senha != value)
                {
                    senha = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}

