﻿using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Interface
{
    public interface IPorteRepositorio : IRepositorio<Porte>
    {
        public Porte BuscarPorId(int id);
        public List<Porte> Listar();
    }
}
