using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
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
            EntrarClickedCommand = new Command(  () => {
                try
                {



                    System.Diagnostics.Debug.Print("Flavio 1" + DateTime.Now);

                     
                        var usuario = new UsuarioBusiness().Login(Usuario.ToLower(), Senha);
                        Global.Usuario = usuario;
                        Global.FormaPagamento = new FormaPagamentoBusiness().GetFormaPagamento(Global.Usuario);
                        Global.CartaoCredito = Global.FormaPagamento.IdCartaoCredito;

                    System.Diagnostics.Debug.Print("Flavio 2" + DateTime.Now);

                    //MessagingCenter.Send<String>("", "LoginSucesso");
                    App.Current.MainPage = new NavigationPage(new Views.MainPage());

                    System.Diagnostics.Debug.Print("Flavio 3" + DateTime.Now);


                }
                catch (Exception e)
                {
                    App.MensagemAlerta(e.Message);
                }
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
