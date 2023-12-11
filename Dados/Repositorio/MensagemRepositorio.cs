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
    public class MensagemRepositorio : Repositorio<Mensagem>
    {
        public MensagemRepositorio(ApplicationDbContext db) : base(db)
        {
        }

        
    }
}
