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
            if(_usuario == null || _usuario.Equals("") || 
               _senha == null || _senha.Equals("")){
                throw new Exception("Preencher todos os campos.");
            }else{
                try
                {
                    var usuarioService = new UsuarioServices();
                    // var variavel = usuarioService.UsuarioValido(_usuario, _senha);
                    var usuario = usuarioService.GetLogin(_usuario, _senha);
                    return usuario;
                }
                catch (Exception e)
                {
                    throw new Exception("Usuário ou senha inválidos. Tentar novamente.");
                }
            }
        }
    }
}

