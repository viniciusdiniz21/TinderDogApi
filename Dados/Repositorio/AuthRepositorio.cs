﻿using Dados.EntityFramework;
using Dados.Interface;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio
{
    public class AuthRepositorio : IAuthRepositorio
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AuthRepositorio(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Usuario BuscarUsuario(string usuario)
        {
            return _applicationDbContext.Usuario.FirstOrDefault(u => u.Nome == usuario);
        }

        public async Task<Usuario> Cadastrar(Usuario usuario)
        {
            _applicationDbContext.Usuario.Add(usuario);
            await _applicationDbContext.SaveChangesAsync();
            return usuario;
        }
    }
}
