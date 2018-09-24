using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using App6.Layers.Business;
using App6.Models;
using Xamarin.Forms;

namespace App6.ViewModels
{
	public class PerfilViewModel
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String NomeCompleto { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Username { get; set; }
        public String DtNascimento { get; set; }

        public PerfilViewModel()
        {
            NomeCompleto = Global.Usuario.PrimeiroNome + " " + Global.Usuario.Sobrenome;
            Email = Global.Usuario.Email;
            Telefone = Global.Usuario.Telefone;
            Username = "@"+Global.Usuario.NmUsuario;
            DtNascimento = Global.Usuario.DtNascimento;
        }



    }
}