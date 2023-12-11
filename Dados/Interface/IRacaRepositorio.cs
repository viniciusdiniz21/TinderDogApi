using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Interface
{
    public interface IRacaRepositorio : IRepositorio<Raca>
    {
        public Raca BuscarPorId(int id);
    }
}
