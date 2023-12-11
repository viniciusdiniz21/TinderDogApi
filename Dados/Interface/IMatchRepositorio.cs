using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Interface
{
    public interface IMatchRepositorio  : IRepositorio<Match>
    {
        public List<Match> Listar();
        public List<Match> BuscarPorUsuarioId(int userId);
    }
}
