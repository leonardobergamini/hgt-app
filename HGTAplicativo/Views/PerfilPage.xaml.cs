using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HGTAplicativo.Views
{
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();
        }

        public void ClickedBotaoSair(Object o, EventArgs e)
        {

            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
