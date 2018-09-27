using System;
namespace App6.Models
{
    public class TitularTicketModel
    {
        public String IdTitular { get; set; }
        public String PrimeiroNome { get; set; }
        public String Sobrenome { get; set;}
        public DateTime DtNascimento { get; set; }
        public String CPF { get; set;}
        public String Telefone { get; set; }
        public String Email { get; set; }
        public UsuarioModel Usuario { get; set; }

        public TitularTicketModel(UsuarioModel usuario)
        {
            Usuario = usuario;
        }
    }
}
