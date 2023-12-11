using Dominio;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IAnimalService
    {
        public List<Animal> Listar();
        public Animal BuscarPorId(int id);
        public Animal BuscarPorUsuarioId(int usuarioId);
        public bool Adicionar(Animal ent);
        public bool Editar(Animal ent);
    }
}
