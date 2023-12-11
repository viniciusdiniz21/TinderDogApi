using Dados.Interface;
using Dominio.Entities;
using Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepositorio _authRepositorio;
        public Usuario BuscarUsuario(string usuario)
        {
           return _authRepositorio.BuscarUsuario(usuario);
        }

        public Task<Usuario> Cadastrar(Usuario usuario)
        {
           return _authRepositorio.Cadastrar(usuario);
        }
    }
}
