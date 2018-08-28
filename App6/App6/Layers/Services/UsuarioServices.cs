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
                    Senha = _senha
                };
                return _user;
            }
            else
            {
                return null;
            }

        }

        public UsuarioModel Get(int _id)
        {
            if (_id == 1)
            {
                var _user = new UsuarioModel
                {
                    IdUsuario = 1,
                    Usuario = "admin",
                    Email = "admin@admin.com.br",
                    Nome = "Administrador",
                    Sobrenome = "Administrativo",
                    Cpf = "123.123.123-00",
                    Telefone = 1188880000
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

