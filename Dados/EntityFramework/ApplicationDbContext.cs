﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSF.Dominio.Entities;
using PSF.Dados.EntityFramework.Configuration;
using PSF.Dominio;

namespace PSF.Dados.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

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
                                    Database = BD044748; 
                                    User ID = RA044748; 
                                    Password = 044748;
                                    TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            base.OnModelCreating(modelBuilder);

        }


    }
}