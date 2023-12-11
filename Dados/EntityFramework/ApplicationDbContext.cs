﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.EntityFramework.Configuration;
using Dominio;
using Dominio.Entities;

namespace Dados.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext()
        //{

        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Curtida> Curtida { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Match> Match { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93,1434; 
                                    Database = BD047106; 
                                    User ID = RA047106; 
                                    Password = 047106;
                                    TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            base.OnModelCreating(modelBuilder);

        }


    }
}