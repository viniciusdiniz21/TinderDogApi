using Microsoft.EntityFrameworkCore;
using Dados.EntityFramework;
using Dados.Interface;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public Usuario BuscarPorId(int id)
        {
            return  Db.Usuario.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Usuario> Listar()
        {
            return  Db.Usuario.AsNoTracking().ToList();
        }
    }
}
