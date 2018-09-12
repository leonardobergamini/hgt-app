using System;
using App6.Models;
using Xamarin.Forms;

namespace App6.Layers.Services
{
    public class UsuarioServices
    {
        public UsuarioModel GetLogin(String _usuario, String _senha)
        {

            if (_usuario.Equals("admin") && _senha.Equals("admin"))
            {
                var _user = new UsuarioModel
                {
                    IdUsuario = 1,
                    Usuario = _usuario,
                    Senha = _senha,
                    Nome = "Administrador",
                    Sobrenome = "Administrativo",
                    Email = "admin@admin.com.br",
                    Cpf = "123.123.123-00",
                    Telefone = 1188880000

                };
                return _user;

            }
            else if (_usuario.Equals("leonardo") && _senha.Equals("leonardo"))
            {
                var _user = new UsuarioModel
                {
                    IdUsuario = 2,
                    Usuario = _usuario,
                    Senha = _senha,
                    Nome = "Leonardo",
                    Sobrenome = "Bergamini",
                    Email = "leonardo@email.com.br",
                    Cpf = "432.112.157-20",
                    Telefone = 11944045697
                };

                return _user;
            }
            else
            {
                return null;
            }

        }

    }
}

