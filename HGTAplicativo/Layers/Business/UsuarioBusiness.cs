using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class UsuarioBusiness
    {
        public UsuarioModel Login(String _usuario, String _senha)
        {
            if (_usuario == null || _usuario.Equals("") ||
               _senha == null || _senha.Equals(""))
            {
                throw new Exception("Preencher todos os campos.");
            }
            else
            {
                try
                {
                    var usuario = new UsuarioServices().GetLogin(_usuario.ToLower(), _senha);
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
