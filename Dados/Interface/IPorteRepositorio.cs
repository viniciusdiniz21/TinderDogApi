﻿using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.Interface
{
    public interface IPorteRepositorio : IRepositorio<Porte>
    {
        public Porte BuscarPorId(int id);
    }
}
