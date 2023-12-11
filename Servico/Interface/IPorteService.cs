using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IPorteService : IDisposable
    {
        public List<Porte> Listar();
        public Porte BuscarPorId(int id);
        public bool Adicionar(Porte ent);
        public bool Editar(Porte ent);
    }
}
