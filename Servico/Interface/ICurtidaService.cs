﻿using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface ICurtidaService : IDisposable
    {
        bool Interacao(Curtida ent);
        List<Curtida> Curtidas();
    }
}
