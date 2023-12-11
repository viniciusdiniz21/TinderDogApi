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
    public class MatchRepositorio : Repositorio<Match>, IMatchRepositorio
    {
        public MatchRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public List<Match> BuscarPorUsuarioId(int userId)
        {
            return Db.Match.AsNoTracking().Where(m => m.Cachorro1 == userId).ToList();
        }

        public List<Match> Listar()
        {
            return Db.Match.AsNoTracking().Include(a => a.Mensagens).ToList();
        }
    }
}
