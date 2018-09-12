using System;
using App6.Layers.Data;
using App6.Layers.Services;
using App6.Models;
using Xamarin.Forms;

namespace App6.Layers.Business
{
    public class UsuarioBusiness
    {
        public UsuarioModel Login(String _usuario, String _senha)
        {
            var usuarioData = new UsuarioData();
            var usuario = usuarioData.GetLogin(_usuario, _senha);
            if (usuario == null)
            {            
               throw new Exception("Usuário ou senha inválida");
            }
            else
            {
                return usuario;
            }
        }
    }
}

