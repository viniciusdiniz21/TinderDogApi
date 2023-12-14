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
    public class ImagemRepositorio : Repositorio<Imagem>, IImagemRepositorio
    {
        public ImagemRepositorio(ApplicationDbContext db) : base(db)
        {
        }
    }
}
