using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IImagemService : IDisposable
    {
        public bool Adicionar(Imagem ent);
        public bool Editar(Imagem ent);
    }
}
