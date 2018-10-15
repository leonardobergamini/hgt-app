using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using HGTAplicativo.Layers.Business;
using HGTAplicativo.Models;
using Xamarin.Forms;


namespace HGTAplicativo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand EntrarClickedCommand { get; private set; }

        public LoginViewModel()
        {
        
            EntrarClickedCommand = new Command(async () =>
            {
                try
                {
                    UserDialogs.Instance.ShowLoading("Carregando...");
                    await GetUsuario();
                    App.Current.MainPage = new NavigationPage(new Views.MainPage());

                }
                catch (Exception e)
                {
                    UserDialogs.Instance.HideLoading();
                    App.MensagemAlerta(e.Message);
                }
            });
        }

        public async Task GetUsuario(){

            await Task.Run(() =>
            {
                Global.Usuario = new UsuarioBusiness().Login(Usuario, Senha);
                Global.FormaPagamento = new FormaPagamentoBusiness().GetFormaPagamento(Global.Usuario);
                Global.CartaoCredito = Global.FormaPagamento.IdCartaoCredito;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String usuario;
        public String Usuario
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

        private String senha;
        public String Senha
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
