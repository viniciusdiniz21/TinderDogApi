using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IAuthService
    {
        Task<Usuario> Cadastrar(Usuario usuario);
        Task<Usuario> BuscarUsuario(string usuario);
    }
}
