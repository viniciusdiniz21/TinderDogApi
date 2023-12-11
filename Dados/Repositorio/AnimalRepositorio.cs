using Microsoft.EntityFrameworkCore;
using Dados.EntityFramework;
using Dados.Interface;
using Dominio;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class AnimalRepositorio : Repositorio<Animal>, IAnimalRepositorio
    {
        public AnimalRepositorio(ApplicationDbContext context) : base(context)
        {

        }

        public Animal BuscarPorId(int id)
        {
            return  Db.Animal.Where(a => a.Id == id).FirstOrDefault();
        }
        
        public Animal BuscarPorUsuarioId(int usuarioId)
        {
            return  Db.Animal.Where(a => a.UsuarioId == usuarioId).FirstOrDefault();
        }

        public async Task<List<Animal>> Listar()
        {
            return await Db.Animal.AsNoTracking().Include(a => a.Raca).Include(a => a.Porte).ToListAsync();
        }
    }
}
