using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Animal Animal { get; set; }
        public List<Match> Matchs { get; set; }
    }
}
