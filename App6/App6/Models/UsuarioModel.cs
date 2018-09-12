using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App6.Models
{
    public class UsuarioModel
    {


        public int IdUsuario { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime Dt_nascimento { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public long Telefone { get; set; }
        public String Usuario { get; set; }
        public String Senha { get; set; }

        public UsuarioModel(string _usuario, string _senha)
        {
            this.Usuario = _usuario;
            this.Senha = _senha;
        }

        public UsuarioModel()
        {

        }

    }
}

