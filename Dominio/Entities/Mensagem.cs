using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Mensagem : Entity
    {
        public string Conteudo { get; set; }
        public int MatchId { get; set; }
        public int Cachorro1 { get; set; }
        public int Cachorro2 { get; set; }
        public DateTime DataHora { get; set; }
    }
}
