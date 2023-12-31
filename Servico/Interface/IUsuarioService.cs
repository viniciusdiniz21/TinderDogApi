﻿using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IUsuarioService : IDisposable
    {
        public List<Usuario> Listar();
        public Usuario BuscarPorId(int id);
        public bool Adicionar(Usuario ent);
        public bool Editar(Usuario ent);
    }
}
