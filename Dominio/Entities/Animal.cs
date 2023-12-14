using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Animal : Entity
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public List<Imagem> Imagems { get; set; }
        public int PorteId { get; set; }

        public int RacaId { get; set; }

        public int UsuarioId { get; set; }
        public DateTime DataNascimento { get; set; }
        public Raca? Raca { get; set; }
        public Porte? Porte { get; set; }
        public List<Curtida>? Curtida { get; set; }
    }
}
