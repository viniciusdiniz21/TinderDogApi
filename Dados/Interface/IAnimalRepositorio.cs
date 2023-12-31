﻿using Dominio;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Interface
{
    public interface IAnimalRepositorio : IRepositorio<Animal>
    {
        public Task<List<Animal>> Listar();
        public Animal BuscarPorId(int id);
        public Animal BuscarPorUsuarioId(int usuarioId);
    }
}
