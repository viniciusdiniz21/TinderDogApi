using Microsoft.EntityFrameworkCore;
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
    public class PorteRepositorio : Repositorio<Porte>, IPorteRepositorio
    {
        public PorteRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public Porte BuscarPorId(int id)
        {
            return Db.Portes.Where(a => a.Id == id).AsNoTracking().FirstOrDefault();
        }

        public List<Porte> Listar()
        {
            return Db.Portes.AsNoTracking().ToList();
        }
    }
}
