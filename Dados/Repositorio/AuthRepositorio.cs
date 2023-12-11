using Dados.EntityFramework;
using Dados.Interface;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class AuthRepositorio : IAuthRepositorio
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AuthRepositorio(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Usuario> BuscarUsuario(string usuario)
        {
            return await _applicationDbContext.Usuario.AsNoTracking().Include(u => u.Animal).ThenInclude(c => c.Curtida).Where(u => u.Nome == usuario).FirstOrDefaultAsync() ;
        }

        public async Task<Usuario> Cadastrar(Usuario usuario)
        {
            _applicationDbContext.Usuario.Add(usuario);
            await _applicationDbContext.SaveChangesAsync();
            return usuario;
        }
    }
}
