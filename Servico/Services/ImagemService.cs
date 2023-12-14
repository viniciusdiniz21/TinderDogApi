using Dados.Interface;
using Dominio.Entities;
using Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Services
{
    public class ImagemService : IImagemService
    {

        private readonly IImagemRepositorio _imagemRepositorio;

        public ImagemService(IImagemRepositorio imagemRepositorio)
        {
            _imagemRepositorio = imagemRepositorio;
        }

        public bool Adicionar(Imagem ent)
        {
            return _imagemRepositorio.Adicionar(ent);
        }

        public void Dispose()
        {
            _imagemRepositorio.Dispose();
        }

        public bool Editar(Imagem ent)
        {
            return _imagemRepositorio.Atualizar(ent);
        }
    }
}
