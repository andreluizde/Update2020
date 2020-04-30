using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema5.Models
{
    public interface IAutenticacao
    {
        string GetConnectionString();
        string RegistrarUsuario(Usuario usuario);
        string ValidarLogin(Usuario usuario);
        string RegistrarCliente(Cliente cliente);
    }
}
