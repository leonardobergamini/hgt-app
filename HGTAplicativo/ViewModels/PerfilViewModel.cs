using System;
using HGTAplicativo.Models;

namespace HGTAplicativo.ViewModels
{
    public class PerfilViewModel
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String NomeCompleto { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public String Username { get; set; }
        public DateTime DtNascimento { get; set; }

        public PerfilViewModel()
        {
            NomeCompleto = Global.Usuario.PrimeiroNome + " " + Global.Usuario.Sobrenome;
            Email = Global.Usuario.Email;
            Telefone = Global.Usuario.Telefone;
            Username = "@" + Global.Usuario.NmUsuario;
            DtNascimento = Global.Usuario.DtNascimento;
        }
    }
}
