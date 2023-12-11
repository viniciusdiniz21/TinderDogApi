using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Match : Entity
    {
        public int Cachorro1 { get; set; }
        public int Cachorro2 { get; set; }
        public List<Mensagem> Mensagens { get; set; }
    }
}
